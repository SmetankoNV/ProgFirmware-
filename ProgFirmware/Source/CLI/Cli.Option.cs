namespace ProgFirmware.Source.CLI
{
    public class CliOption
    {
        #region Свойства

        /// <summary>
        /// Значение опции
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Короткое имя
        /// </summary>
        public string ShortName { get; private set; }

        /// <summary>
        /// Длинное имя
        /// </summary>
        public string LongName { get; private set; }

        /// <summary>
        /// Текстовое описание опции
        /// </summary>
        public string HelpText { get; private set; }

        /// <summary>
        /// Признак обязательного поля
        /// </summary>
        public bool Require { get; private set; }

        /// <summary>
        /// Признак найденной опции в аргументах
        /// </summary>
        public bool IsPresent => Value != null;

        #endregion

        #region Конструктор

        public CliOption(string shortName, string longName, string helpText, bool require = false)
        {
            ShortName = shortName;
            LongName = longName;
            HelpText = helpText;
            Require = require;
        }

        /// <summary>
        /// Текстовое представление
        /// </summary>
        public override string ToString()
        {
            return $"{HelpText} (-{ShortName} --{LongName})";
        }

        #endregion
    }
}