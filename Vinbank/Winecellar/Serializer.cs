/// Serializer.cs
/// Ann-Marie Bergström  ai2436 2018
/// 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Winecellar
{
    public class Serializer
    {
            /// <summary>
            /// serialize object
            /// </summary>
            /// <param name="obj"> Object to be serialized.</param>
            /// <param name="filePath">File path including the name of the file to be serialized.</param>
            public static void Serialize(string filePath, object obj)
            {
                FileStream fileObj = null; //declare fileObj as type FileStream, set to null
                try
                {
                    fileObj = new FileStream(filePath, FileMode.Create); //create fileObj and create file if not existing
                    BinaryFormatter binFormatter = new BinaryFormatter(); //declare and create binFormatter as type BinaryFormatter
                    binFormatter.Serialize(fileObj, obj); // serialize and save obj in fileObj
                }
                finally
                {
                    if (fileObj != null)
                        fileObj.Close();
                }
            }

            /// <summary>
            /// deserialize object.
            /// </summary>
            /// <typeparam name="T"> Any object</typeparam>
            /// <param name="filePath">File path including the name of the file to be deserialized</param>
            public static T DeSerialize<T>(string filePath)
            {
                FileStream fileObj = null;
                object obj = null;

                try
                {
                    if (!File.Exists(filePath))
                    {
                        throw new FileNotFoundException("The file is not found. ", filePath); //create object
                    }

                    fileObj = new FileStream(filePath, FileMode.Open); //create fileObj and fill

                    BinaryFormatter binFormatter = new BinaryFormatter(); //declare and create binFormatter as type BinaryFormatter
                    obj = binFormatter.Deserialize(fileObj); //save object
                }
                finally
                {
                    if (fileObj != null)
                    {
                        fileObj.Close();
                    }
                }

                return (T)obj;
            }

    }
}
