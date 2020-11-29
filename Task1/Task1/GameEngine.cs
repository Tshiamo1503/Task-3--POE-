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
        public Map Map{ get => mapDisplay;}

        public GameEngine()
        {
           var MapDimensions = new Map(5,10,5,10,6,5,4);
            mapDisplay = MapDimensions;
           ToString();
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
            for (int i = 0; i < mapDisplay.Width; i++)
            {
                for (int j = 0; j < mapDisplay.Height; j++)
                {
                    output += mapDisplay.Maptiles[j,i];
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

        //Shop shop = new Shop();
    }
}
