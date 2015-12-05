using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romulus
{
    class InputChecker
    {
        public bool isSuccessful(String input)
        {
            mInput = input;
            if (inputIsNotEmpty() &&
                inputContainsOnlyNumerals() &&
                inputIsInPermittedRange())
            {
                return true;
            }
            mErrorCode = setErrorCode();
            return false;
        }
        public int getErrorCode()
        {
            return mErrorCode;
        }
        private int setErrorCode()
        {
            if (!inputIsNotEmpty())
            {
                return 1;
            }
            else if (!inputContainsOnlyNumerals())
            {
                return 2;
            }
            else if (!inputIsInPermittedRange())
            {
                return 3;
            }
            return 0;
        }
        private bool inputIsNotEmpty()
        {
            return mInput.Length > 0;
        }
        private bool inputContainsOnlyNumerals()
        {
            for (int i = 0; i < mInput.Length; i++)
            {
                if (mInput[i] < 48 || mInput[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }
        private bool inputIsInPermittedRange()
        {
            int inputAsInt = Convert.ToInt32(mInput);
            return ((inputAsInt > 0) && (inputAsInt < 4000));
        }

        private String mInput;
        private int mErrorCode;
    }
}