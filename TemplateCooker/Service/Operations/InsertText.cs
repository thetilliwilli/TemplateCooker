﻿using PluginAbstraction;
using TemplateCooker.Domain.Layout;

namespace TemplateCooker.Service.Operations
{
    public class InsertText : IOperationExecutor
    {
        public class Operation : AbstractOperation
        {
            public SrcPosition Position { get; set; }
            public string Text { get; set; }
        }

        public void Execute(IWorkbookAbstraction workbook, object untypedOptions)
        {
            var options = (Operation)untypedOptions;

            var cell = workbook
                .GetSheet(options.Position.SheetIndex)
                .GetRow(options.Position.RowIndex)
                .GetCell(options.Position.ColumnIndex);

            cell.SetValue(options.Text);
        }
    }
}