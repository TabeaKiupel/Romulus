using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romulus
{
    public class ErrorHandler
    {
        public ErrorHandler()
        {
            initializeErrorCodeDict();
        }
        private void initializeErrorCodeDict()
        {
            mErrorCodeDict.Add(1, "");
            mErrorCodeDict.Add(2, "Input contains non-numerals.");
            mErrorCodeDict.Add(3, "Input is out of range (1 - 3999).");
        }
        public String getErrorMessage(int errorCode)
        {
            foreach (KeyValuePair<int, String> entry in mErrorCodeDict)
            {
                if (entry.Key == errorCode)
                {
                    return entry.Value;
                }
            }
            return "";
        }

        private SortedDictionary<int, String> mErrorCodeDict = new SortedDictionary<int, String>();
    }
}
