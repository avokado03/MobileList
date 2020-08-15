using CsvHelper;
using FileMapper.FileModels;
using FileMapper.Interfaces;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace FileMapper.CsvToPdf
{
    public class CsvParser : IParser<CsvIssueModel>
    {
        public List<CsvIssueModel> Parse(string path)
        {
            var csvs = new List<CsvIssueModel>();
            using (var reader = new StreamReader(path))
            using(var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csvReader.Configuration.HasHeaderRecord = false;
                csvReader.Configuration.RegisterClassMap<CsvMapping>();
                csvs = csvReader.GetRecords<CsvIssueModel>().ToList();
            }
            return csvs;
        }
    }
}
