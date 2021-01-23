using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary <T,K>
    {
        // T  = Key K = value 

        T[] key;
        K[] value;
        T[] tempKey;
        K[] tempValue;
        public MyDictonary()
        {
            key = new T[0];
            value = new K[0];

        }
        public void Add(T name,K id )
        {
            tempKey = key;
            tempValue = value;

            key = new T[key.Length + 1];
            value = new K[value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                tempKey[i] = key[i];
            }

            key[key.Length - 1] = name;

            for (int i = 0; i < tempValue.Length; i++)
            {
                tempValue[i] = value[i];
            }

            value[value.Length - 1] = id;


        }

        public int CountKey
        {
            get { return key.Length; }
        }

        public int CountValue
        {
            get { return value.Length; }
        }


    }

}
