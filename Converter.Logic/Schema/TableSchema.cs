﻿using System;
using System.Collections.Generic;
using Converter.Logic.Schema;

namespace Converter.Logic.Schema
{
    public class TableSchema
    {
        public String TableName;

        public String TableSchemaName;

        public List<ColumnSchema> Columns;

        public List<String> PrimaryKey;

        public List<ForeignKeySchema> ForeignKeys;

        public List<IndexSchema> Indexes;
    }
}
