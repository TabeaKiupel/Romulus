using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace romulus
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }

    public class RomanNumeralConverter
    {
        public RomanNumeralConverter(String input)
        {
            mInput = input;
            mInputAsInt = Convert.ToInt32(mInput);
        }

        private int mDivider = 5;
        private int mRemainder = 4;
        private String[] mCurrentMap;
        private String[][] mFullMap = 
        {
            new String[] {"I", "IV", "V", "IX"},
            new String[] {"X", "XL", "L", "XC"},
            new String[] {"C", "CD", "D", "CM"},
            new string[] {"M"}
        };
        private int mCurrentNumber;
        private int[] split()
        {
            int[] splitNumber = new int[4];
            splitNumber[3] = mInputAsInt / 1000; //tausender
            splitNumber[2] = mInputAsInt % 1000 / 100; //hunderter
            splitNumber[1] = mInputAsInt % 100 / 10; //zehner
            splitNumber[0] = mInputAsInt % 10; //einser
            return splitNumber;
        }
        private void clear()
        {

        }
        public String getRomanNumeral()
        {
            mTmpResult.Clear();
            int[] splitNumber = split();
            int splitNumberPart;
            for (int i = mInput.Length; i >= 0; i--)
            {
                splitNumberPart = i - 1;
                if (i == 0)
                {
                    mResult = mTmpResult;
                    return mResult.ToString();
                }
                else
                {
                    mCurrentNumber = splitNumber[splitNumberPart];
                    mCurrentMap = mFullMap[splitNumberPart];

                }
                int tmpRemainder = mCurrentNumber % mDivider;
                if (mCurrentNumber / mDivider > 0)
                {
                    //Merke dritten Eintrag aus Map
                    mTmpResult.Append(mCurrentMap[2]);

                    if (tmpRemainder < mRemainder)
                    {
                        if (tmpRemainder > 0)
                        {
                            for (int j = tmpRemainder; j > 0; j--)
                            {
                                // erster Eintrag der Map an Ergebniss dran hängen
                                mTmpResult.Append(mCurrentMap[0]);
                            }
                        }
                    }
                    else
                    {
                        // vergiss dritten Eintrag aus Map
                        string textToRemove = mCurrentMap[2];
                        int pos = mTmpResult.ToString().IndexOf(textToRemove);
                        mTmpResult.Remove(pos, textToRemove.Length);

                        // Merke vierten Eintrag aus Map
                        mTmpResult.Append(mCurrentMap[3]);

                    }
                }
                else
                {
                    if (tmpRemainder < mRemainder)
                    {
                        for (int j = tmpRemainder; j > 0; j--)
                        {
                            // erster Eintrag der Map an Ergebniss dran hängen
                            mTmpResult.Append(mCurrentMap[0]);
                        }
                    }
                    else
                    {
                        //Merke zweiten Eintrag aus aktueller Map
                        mTmpResult.Append(mCurrentMap[1]);
                    }
                }
            }
            return mResult.ToString();
        }
        private int mInputAsInt;
        private String mInput;
        StringBuilder mResult = new StringBuilder(); // do we really need StringBuilder-Type?
        StringBuilder mTmpResult = new StringBuilder();
    }
}