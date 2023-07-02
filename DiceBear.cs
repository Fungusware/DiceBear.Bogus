
using System;

namespace Bogus
{
    public class DiceBear : DataSet
    {
        private string _diceBearBaseURL = "https://api.dicebear.com/6.x/";

        public string Avatar(string collection = "open-peeps", string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            if (seed == null)
            {
                seed = Guid.NewGuid().ToString();
            }

            return $"{_diceBearBaseURL}{collection}/{format}?seed={seed}&size={size}&scale={scale}";
        }

        public string Adventurer(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("adventurer", format, seed, size);
        }

        public string AdventurerNeutral(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("adventurer-neutral", format, seed, size);
        }

        public string BigEars(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("big-ears", format, seed, size);
        }

        public string BigEarsNeutral(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("big-ears-neutral", format, seed, size);
        }

        public string BigSmile(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("big-smile", format, seed, size);
        }

        public string Bottts(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("bottts", format, seed, size);
        }

        public string BotttsNeutral(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("bottts-neutral", format, seed, size);
        }

        public string Croodles(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("croodles", format, seed, size);
        }

        public string CroodlesNeutral(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("croodles-neutral", format, seed, size);
        }

        public string FunEmoji(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("fun-emoji", format, seed, size);
        }

        public string Icons(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("icons", format, seed, size);
        }

        public string Identicon(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("identicon", format, seed, size);
        }

        public string Initials(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("initials", format, seed, size);
        }

        public string Lorelei(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("lorelei", format, seed, size);
        }

        public string LoreleiNeutral(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("lorelei-neutral", format, seed, size);
        }

        public string Micah(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("micah", format, seed, size);
        }

        public string Miniavs(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("miniavs", format, seed, size);
        }

        public string Notionists(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("notionists", format, seed, size);
        }

        public string NotionistsNeutral(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("notionists-neutral", format, seed, size);
        }

        public string OpenPeeps(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("open-peeps", format, seed, size);
        }

        public string Personas(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("personas", format, seed, size);
        }

        public string PixelArt(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("pixel-art", format, seed, size);
        }

        public string PixelArtNeutral(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("pixel-art-neutral", format, seed, size);
        }

        public string Shapes(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("shapes", format, seed, size);
        }

        public string Thumbs(string format = "svg", string seed = null, int size = 64, int scale = 100)
        {
            return Avatar("thumbs", format, seed, size);
        }
    }
}
