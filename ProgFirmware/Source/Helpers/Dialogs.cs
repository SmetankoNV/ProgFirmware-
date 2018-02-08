using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgFirmware.Source.Helpers
{
    public static class Dialogs
    {
        #region Методы

        /// <summary>
        /// Отображение окна с иконкой инфомрации
        /// </summary>
        public static void ShowInfo(IWin32Window owner, string text, string caption = null)
        {
            MessageBox.Show(owner, text, caption ?? "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Отображение окна с иконкой ошибки
        /// </summary>
        public static void ShowError(IWin32Window owner, string text, string caption = null)
        {
            MessageBox.Show(owner, text, caption ?? "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Отображение окна с иконкой вопроса
        /// </summary>
        public static bool ShowQuestion(IWin32Window owner, string text, string caption = null)
        {
            var result = MessageBox.Show(owner, text, caption ?? "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        /// <summary>
        /// Диалог выбора файла
        /// </summary>
        public static string OpenFile(IWin32Window owner, string filter, string caption = null)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = caption ?? "Выбор...";
                dialog.Filter = filter;

                if (dialog.ShowDialog(owner) == DialogResult.OK)
                {
                    return dialog.FileName;
                }
            }
            return null;
        }

        /// <summary>
        /// Диалог сохранения файла
        /// </summary>
        public static string SaveFile(IWin32Window owner, string filename, string filter = null, string caption = null)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.FileName = filename;
                dialog.Title = caption ?? "Сохранить...";
                if (filter != null)
                {
                    dialog.Filter = filter;
                }

                if (dialog.ShowDialog(owner) == DialogResult.OK)
                {
                    return dialog.FileName;
                }
            }
            return null;
        }

        #endregion
    }
}
