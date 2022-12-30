using Newtonsoft.Json;
using System;
using System.IO;

namespace DummyDB.WorkWithScheme
{
    public class SchemeValidator
    {
        public static bool IsValidToScheme(string[] lines, Scheme scheme)
        {
            for (int i = 1; i < lines.Length; i++)
            {
                string[] lineElements = lines[i].Split(";");
                for (int j = 0; j < scheme.Columns.Count; j++)
                {
                    string lineElement = lineElements[j];

                    switch (scheme.Columns[j].Type)
                    {
                        case "int":
                            if (!int.TryParse(lineElement, out var integer))
                            {
                                DisplayErrorMessage(i, j, lineElements);
                            }
                            break;
                        case "bool":
                            if (!bool.TryParse(lineElement, out var boolean))
                            {
                                DisplayErrorMessage(i, j, lineElements);
                            }
                            break;
                        case "dateTime":
                            if (!DateTime.TryParse(lineElement, out var date))
                            {
                                DisplayErrorMessage(i, j, lineElements);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            return true && IsColumnsValid(lines[0], scheme);
        }

        public static bool IsValidToScheme(string line, Scheme scheme)
        {
            string[] lineElements = line.Split(";");
            for (int j = 0; j < scheme.Columns.Count; j++)
            {
                string lineElement = lineElements[j];

                switch (scheme.Columns[j].Type)
                {
                    case "int":
                        if (!int.TryParse(lineElement, out var integer))
                        {
                            DisplayErrorMessage(j, lineElements);
                        }
                        break;
                    case "bool":
                        if (!bool.TryParse(lineElement, out var boolean))
                        {
                            DisplayErrorMessage(j, lineElements);
                        }
                        break;
                    case "dateTime":
                        if (!DateTime.TryParse(lineElement, out var date))
                        {
                            DisplayErrorMessage(j, lineElements);
                        }
                        break;
                    default:
                        break;
                }
            }

            return true;
        }
        public static Scheme GetScheme(string path)
        {
            return JsonConvert.DeserializeObject<Scheme>(File.ReadAllText(path));
        }

        private static bool IsColumnsValid(string columns, Scheme scheme)
        {
            string[] columnsElements = columns.Split(";");
            for (int i = 0; i < columnsElements.Length; i++)
            {
                if (!(columnsElements[i] == scheme.Columns[i].Name))
                {
                    DisplayErrorMessage(0, 0, columnsElements);
                }
            }
            return true;
        }

        private static void DisplayErrorMessage(int raw, int column, string[] line)
        {
            string errorAccured = $"Error accured! In raw {raw} and column {column} wrong Type!\n";
            string correctionInfo = $"In line: {raw} element: {line[column]}";

            throw new FormatException(string.Concat(errorAccured, correctionInfo));
        }

        private static void DisplayErrorMessage(int column, string[] line)
        {
            string errorAccured = $"Error accured! In column {column} and element: {line[column]}";
            string correctionInfo = $"In column: {column} element: {line[column]}";

            throw new FormatException(string.Concat(errorAccured, correctionInfo));
        }
    }
}
