using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileMapper.FileModels
{
    public class CsvIssueModel : IIssuable
    {
        [Index (0)]
        public string Name { get; set; }

        [Index(1)]
        public int Count { get; set; }
    }
}
