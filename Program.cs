using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDict<int, string> musteriler = new MyDict<int, string>();
            musteriler.Add(1, "Buse" );
            musteriler.Add(2, "Murat");
            musteriler.Add(3, "Pelin");

            Console.WriteLine(musteriler.Count);





        }
    }

    class MyDict<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDict()
        {

            keys = new TKey[0];
            values = new TValue[0];

        }

        public void Add(TKey key , TValue value)
        {

            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

    }

        public int Count
        {
            get { return values.Length; }

        }

        

        public TKey[] MyProperty
        {
            get { return keys; }
            set { keys = value; }
        }


        

        public TValue[] Value
        {
            get { return values; }
            set { values = value; }
        }




    }





}
