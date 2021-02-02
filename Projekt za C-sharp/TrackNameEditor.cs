using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_za_C_sharp
{
    public static class TrackNameEditor
    {
        public static string RemoveDashAndExtension(string trackName)
        {
            if (!trackName.Contains("-") && !trackName.Contains(".mp3")) return trackName;
            else
            {
                int indexOfDash = trackName.IndexOf('-'); 
                trackName = trackName.Remove(indexOfDash - 1, 1); //Removes first whitespace between band name and song name
                indexOfDash = trackName.IndexOf('-');
                trackName = trackName.Remove(indexOfDash + 1, 1);  //Removes second whitespace between band name and song name
                trackName = trackName.Replace('-', ' ');
                trackName = trackName.Remove(trackName.Length - 4);
            }
            return trackName;
        }
    }
}
