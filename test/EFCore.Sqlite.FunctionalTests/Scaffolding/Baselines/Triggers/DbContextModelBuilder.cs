// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    public partial class DbContextModel
    {
        private DbContextModel()
            : base(skipDetectChanges: false, modelId: new Guid("00000000-0000-0000-0000-000000000000"), entityTypeCount: 1)
        {
        }

        partial void Initialize()
        {
            var data = DataEntityType.Create(this);

            DataEntityType.CreateAnnotations(data);

            AddRuntimeAnnotation("Relational:RelationalModel", CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);

            var data = FindEntityType("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data")!;

            var defaultTableMappings = new List<TableMappingBase<ColumnMappingBase>>();
            data.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings);
            var microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase = new TableBase("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data", null, relationalModel);
            var blobColumnBase = new ColumnBase<ColumnMappingBase>("Blob", "BLOB", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase)
            {
                IsNullable = true
            };
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase.Columns.Add("Blob", blobColumnBase);
            var idColumnBase = new ColumnBase<ColumnMappingBase>("Id", "INTEGER", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase);
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase.Columns.Add("Id", idColumnBase);
            relationalModel.DefaultTables.Add("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase);
            var microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase = new TableMappingBase<ColumnMappingBase>(data, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase, true);
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase.AddTypeMapping(microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase, false);
            defaultTableMappings.Add(microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)idColumnBase, data.FindProperty("Id")!, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)blobColumnBase, data.FindProperty("Blob")!, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase);

            var tableMappings = new List<TableMapping>();
            data.SetRuntimeAnnotation("Relational:TableMappings", tableMappings);
            var dataTable = new Table("Data", null, relationalModel);
            var idColumn = new Column("Id", "INTEGER", dataTable);
            dataTable.Columns.Add("Id", idColumn);
            var blobColumn = new Column("Blob", "BLOB", dataTable)
            {
                IsNullable = true
            };
            dataTable.Columns.Add("Blob", blobColumn);
            var pK_Data = new UniqueConstraint("PK_Data", dataTable, new[] { idColumn });
            dataTable.PrimaryKey = pK_Data;
            var pK_DataUc = RelationalModel.GetKey(this,
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data",
                new[] { "Id" });
            pK_Data.MappedKeys.Add(pK_DataUc);
            RelationalModel.GetOrCreateUniqueConstraints(pK_DataUc).Add(pK_Data);
            dataTable.UniqueConstraints.Add("PK_Data", pK_Data);
            dataTable.Triggers.Add("Trigger1", data.FindDeclaredTrigger("Trigger1"));
            dataTable.Triggers.Add("Trigger2", data.FindDeclaredTrigger("Trigger2"));
            relationalModel.Tables.Add(("Data", null), dataTable);
            var dataTableMapping = new TableMapping(data, dataTable, true);
            dataTable.AddTypeMapping(dataTableMapping, false);
            tableMappings.Add(dataTableMapping);
            RelationalModel.CreateColumnMapping(idColumn, data.FindProperty("Id")!, dataTableMapping);
            RelationalModel.CreateColumnMapping(blobColumn, data.FindProperty("Blob")!, dataTableMapping);
            return relationalModel.MakeReadOnly();
        }
    }
}
