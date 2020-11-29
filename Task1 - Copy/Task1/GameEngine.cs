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
        public Map Map { get; private set; }

        public GameEngine()
        {
            var MapDimensions = new Map(8, 10, 8, 10, 10, 10, 5);
            Map = MapDimensions;
            
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

        public override string ToString()
        {         
            string output= "";
            for (int i = 0; i < Map.Width; i++)
            {
                for (int j = 0; j < Map.Height; j++)
                {
                    output += Map.Maptiles[j, i];
                }
                output += "\n";
            }
            return output;
        }

        public void Save()// =============saving in binary format
        {


            if (File.Exists("Map Data"))
            {
                Stream stream = File.Open("Map-Data.dat", FileMode.Open);
                BinaryFormatter Bin = new BinaryFormatter();

                Bin.Serialize(stream, Map);
                stream.Close();
            }
            else
            { 
            Stream stream = File.Open("Map-Data.dat", FileMode.Create);
            BinaryFormatter Bin = new BinaryFormatter();

            Bin.Serialize(stream, Map);
            stream.Close();
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
            info.AddValue("Map-Display", Map);
        }

        public GameEngine(SerializationInfo info, StreamingContext context)
        {
            Map = (Map)info.GetValue("Map-Display", typeof(Map));
        }

        public void Load()
        {
            Map = null;

            Stream stream = File.Open("Map-Data.dat", FileMode.Open);
            BinaryFormatter Bin = new BinaryFormatter();

            Map = (Map)Bin.Deserialize(stream);
            stream.Close();
        }

        //Shop shop = new Shop();
    }
}
