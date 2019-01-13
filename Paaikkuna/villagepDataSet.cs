using System.Data.SqlClient;

namespace Paaikkuna
{


    partial class villagepDataSet
    {
        partial class OstoskorinLoppusummaDataTable
        {
        }

        partial class AsiakasDataTable
        {
        }

        partial class LaskuttamattomatDataTable
        {
        }
    }
}

namespace Paaikkuna.villagepDataSetTableAdapters
{
    public partial class Palveluhistoria2TableAdapter
    {
        /*
        /// <summary> 
        /// Return CustomerDataTable using a WHERE CustomerIdentifier IN clause e.g.  
        /// WHERE CustomerIdentifier IN (1,2,4) 
        /// </summary> 
        /// <param name="dataTable"></param> 
        /// <param name="Values"></param> 
        /// <returns></returns> 
        /// <remarks> 
        /// In this case I created a new SELECT in the xsd for the Customer table with  
        /// a WHERE condition that has a parameter named @InValues which is unique,  
        /// meaning no other queries in the xsd have this name. 
        /// The code below then finds that query, removes the WHERE condition in place  
        /// of one with a IN clause and uses the int array (converted to a string array)  
        /// for returning records. 
        /// </remarks> 
        public int FillByInValuesKaikki(villagepDataSet.Palveluhistoria2DataTable dataTable, int[] Values)
        {

            for (int i = 0; i < CommandCollection.Length; i++)
            {
                if (CommandCollection[i].Parameters.Count > 0)
                {
                    foreach (SqlParameter item in CommandCollection[i].Parameters)
                    {
                        if (item.ParameterName == "@InValues")
                        {
                            Adapter.SelectCommand = CommandCollection[i].Clone();
                            int whereLocation = Adapter.SelectCommand
                                .CommandText.IndexOf("WHERE", System.StringComparison.Ordinal);

                            var selectTextNoWhereCondition = Adapter.SelectCommand
                                .CommandText.Substring(0, whereLocation);
                            var newSelectStatmentText = selectTextNoWhereCondition +
                                " WHERE CustomerIdentifier IN (" + string.Join(",", Values) + ")";

                            //Adapter.SelectCommand = new SqlCommand() { Connection = this.Connection };
                            Adapter.SelectCommand.CommandText = newSelectStatmentText;

                            if ((ClearBeforeFill == true))
                            {
                                dataTable.Clear();
                            }

                            int returnValue = this.Adapter.Fill(dataTable);
                            return returnValue;

                        }
                    }
                }
            }

            throw new System.Exception("Failed to locate SELECT");

        }
        */
    }



    partial class OstoskorinLoppusummaTableAdapter
    {
    }

    partial class VarausTableAdapter
    {
    }

    public partial class AsiakasTableAdapter
    {
    }
}
