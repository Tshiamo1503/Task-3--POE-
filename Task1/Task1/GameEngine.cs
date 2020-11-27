using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.IO;

namespace Task1
{
    [Serializable()]
    class GameEngine: ISerializable
    {
        private Map mapDisplay;

        public Map Map
        {
            get { return mapDisplay; }
        }

        public GameEngine()
        {
           // var MapDimensions = new Map();
        }

        public bool MovePlayer(Character.Movement direction)
        {
            bool move = false;

            bool looted = false;
            if (direction == Character.Movement.Nothing)
            {
                looted = false;
            }
            else
            {
                looted = true;
            }

            if (looted == true)
            {
                
            }
            return move;
        }

        public void Save()// =============saving in binary format
        {
            mapDisplay = new Map(5, 20, 5, 20, 10, 10);

            if (File.Exists("Map Data"))
            {
                Stream stream = File.Open("Map-Data.dat", FileMode.Open);
                BinaryFormatter Bin = new BinaryFormatter();

                Bin.Serialize(stream, mapDisplay);
                stream.Close();
            }
            else
            { 
            Stream stream = File.Open("Map-Data.dat", FileMode.Create);
            BinaryFormatter Bin = new BinaryFormatter();

            Bin.Serialize(stream, mapDisplay);
            stream.Close();
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
            info.AddValue("Map-Display", mapDisplay);
        }

        public GameEngine(SerializationInfo info, StreamingContext context)
        {
            mapDisplay = (Map)info.GetValue("Map-Display", typeof(Map));
        }

        public void Load()
        {
            mapDisplay = null;

            Stream stream = File.Open("Map-Data.dat", FileMode.Open);
            BinaryFormatter Bin = new BinaryFormatter();

            mapDisplay = (Map)Bin.Deserialize(stream);
            stream.Close();
        }
    }
}
