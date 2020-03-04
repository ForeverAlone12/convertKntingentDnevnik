using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex = Microsoft.Office.Interop.Excel;

namespace Convert
{
    class Excel
    {
        public void readExcelFromKontingent(string fullFileName)
        {
            Ex.Application excelApp = new Ex.Application();
            excelApp.Visible = false;
            Ex.Workbook workbook = excelApp.Workbooks.Open(fullFileName);
            Ex.Worksheet sheet = (Ex.Worksheet)workbook.Sheets[1];

            Ex.Range range = sheet.UsedRange;

            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;


            DataTable dataTable = new DataTable();
            List<string> header = new List<string>();
            for (int col = 1; col<colCount; col++)
            {            
                header.Add(sheet.Cells[1, col].Value);
            }

            dataTable.NewRow();
            dataTable.Rows.Add();

            workbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }

    }
}
