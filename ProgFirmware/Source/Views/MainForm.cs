using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgFirmware.Source.Adapters;
using ProgFirmware.Source.Firmware;
using ProgFirmware.Source.Helpers;

namespace ProgFirmware
{
    public partial class MainForm : Form
    {

        private uint Serial
        {
            get { return (uint)textBoxSerial.Text.ToIntEx(); }
            set { textBoxSerial.Text = value.ToStringEx(); }
        }

        private FirmwareMcu _firmware;

        private IAdapter Adapter;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очистка текста лога
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
        }

        /// <summary>
        /// Выбор HEX-файла
        /// </summary>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.Filter = "*.hex, *.exobin|*.hex;*.exobin";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    ReadFirmware(dialog.FileName);
                }
            }
        }

        /// <summary>
        /// Чтение файла и его разбор
        /// </summary>
        private void ReadFirmware(string location)
        {
            try
            {
                    _firmware = FirmwareMcu.LoadFromHexFile(location);
                    labelFirmLocation.Text = Files.GetFileNameAndExt(_firmware.Location);
                    labelFirmType.Text = _firmware.Boot.Device.Typ.ToString();
                    labelBootName.Text = _firmware.Boot.Name;
                    labelBootBuild.Text = _firmware.Boot.BuildTime.ToString("dd MMM yyyy, HH:MM:ss");
                    labelBootVersion.Text = _firmware.Boot.Version.ToString();
                    labelAppName.Text = _firmware.App.Name;
                    labelAppBuild.Text = _firmware.App.BuildTime.ToString("dd MMM yyyy, HH:MM:ss");
                    labelAppVersion.Text = _firmware.App.Version.ToString();
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        /// <summary>
        /// Увеличение заводского номера
        /// </summary>
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (Serial < 0xFFFFFFFF)
            {
                Serial += 1;
            }
        }

        /// <summary>
        /// Уменьшение заводского номера
        /// </summary>
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (Serial > 0)
            {
                Serial -= 1;
            }
        }

        private void buttonProgram_Click(object sender, EventArgs e)
        {
            if (_firmware == null)
            {
                ShowException(new Exception("Select HEX file"));
                return;
            }

            if (!Dialogs.ShowQuestion(this, $"Program device {_firmware.App.Name} S/N {Serial}", "Correct?"))
            {
                return;
            }

            richTextBoxLog.AppendText("Checking connection...");
            if (ExecuteCommand(AdapterCmdType.Check, true))
            {
                richTextBoxLog.AppendText("OK\r\n");
            }
            else
            {
                richTextBoxLog.AppendText("ERROR\r\n");
                richTextBoxLog.AppendText("Programing aborted\r\n");
                return;
            }


            richTextBoxLog.AppendText("Programming...");
            if (ExecuteCommand(AdapterCmdType.Program, true))
            {
                richTextBoxLog.AppendText("OK\r\n");
            }
            else
            {
                richTextBoxLog.AppendText("ERROR\r\n");
                richTextBoxLog.AppendText("Programing aborted\r\n");
                return;
            }

            richTextBoxLog.AppendText("Writing serial...");
            if (ExecuteCommand(AdapterCmdType.WriteSerial, true))
            {
                richTextBoxLog.AppendText("OK\r\n");
            }
            else
            {
                richTextBoxLog.AppendText("ERROR\r\n");
                richTextBoxLog.AppendText("Programing aborted\r\n");
                return;
            }

            richTextBoxLog.AppendText("Locking...");
            if (ExecuteCommand(AdapterCmdType.Lock))
            {
                richTextBoxLog.AppendText("OK\r\n");
                richTextBoxLog.AppendText("Programing done\r\n");
            }
            else
            {
                richTextBoxLog.AppendText("ERROR\r\n");
                richTextBoxLog.AppendText("Programing aborted\r\n");
            }
        }

        /// <summary>
        /// Выполнение команды
        /// </summary>
        private bool ExecuteCommand(AdapterCmdType cmd, bool hidden = false)
        {
            try
            {
                switch (cmd)
                {
                    case AdapterCmdType.Check:
                        Adapter.Check();
                        break;
                    case AdapterCmdType.Erase:
                        Adapter.Erase();
                        break;
                    case AdapterCmdType.Lock:
                        Adapter.Lock();
                        break;
                    case AdapterCmdType.Program:
                        Adapter.Program(_firmware.Location);
                        break;
                    case AdapterCmdType.ResetSoft:
                        Adapter.ResetSoft();
                        break;
                    case AdapterCmdType.WriteSerial:
                        Adapter.WriteSerial(Serial);
                        break;
                    default:
                        throw new NotImplementedException();
                }

                if (!hidden)
                {
                    ShowOk("OK");
                }

                return true;
            }
            catch (Exception ex)
            {
                ShowException(ex);
                return false;
            }
        }

        private void ShowException(Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowOk(string text)
        {
            MessageBox.Show(text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
