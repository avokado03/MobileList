using CsvHelper.Configuration;
using FileMapper.FileModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileMapper.CsvToPdf
{
    public class CsvMapping : ClassMap<CsvIssueModel>
    {
        public CsvMapping()
        {
            Map(m => m.Name).Index(0);
            Map(m => m.Count).Index(1);
        }
    }
}
