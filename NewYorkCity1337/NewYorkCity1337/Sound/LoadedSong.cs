﻿using Microsoft.Xna.Framework.Media;
using NewYorkCity1337.Engine;

namespace Sound
{
    public class LoadedSong
    {
        private readonly string songName;
        private const string SongFolder = "Music/";

        public LoadedSong(string songName)
        {
            this.songName = songName;
        }

        public Song Get()
        {
            return new GameInstance().Load<Song>(SongFolder + songName);
        }
    }
}
