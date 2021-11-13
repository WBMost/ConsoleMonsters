using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeFight
{
    class Monster
    {
        private string mName,mType;
        private int mLvl, mAtk, mDef, mSAtk, mSDef, mSpe;
        private int mHP, mMHP;
        private Attack[] moveSet;
        private bool poisoned;
        public Monster(int monster,int lvl)
        {
            Random rng = new Random();
            poisoned = false;
            int stat = 0;
            int strat = 0;
            mLvl = lvl;
            moveSet = new Attack[4];
            switch (monster)
            {
                case 1:
                    mName = "Bulbasaur";
                    mType = "grass";
                    for(int x = 1; x <= lvl; x++) { strat=rng.Next(1, 4); stat += strat; }
                    mMHP = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 49 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 49 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSAtk = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSDef = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 45 + stat;
                    break;
                case 2:
                    mName = "Ivysaur";
                    mType = "grass";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mMHP = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 62 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 63 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSAtk = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSDef = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 60 + stat;
                    break;
                case 3:
                    mName = "Venusaur";
                    mType = "grass";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 82 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 83 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSAtk = 100 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSDef = 100 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 80 + stat;
                    break;
                case 4:
                    mName = "Charmander";
                    mType = "fire";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mMHP = 39 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 52 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 43 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSAtk = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 65 + stat;  rng.Next(1, 4);
                    break;
                case 5:
                    mName = "Charmeleon";
                    mType = "fire";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mMHP = 58 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 64 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 58 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSAtk = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 4); stat += strat; }
                    mSpe = 80 + stat;
                    break;
                case 6:
                    mName = "Charizard";
                    mType = "fire/flying";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 78 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 84 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 78 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSAtk = 109 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 3); stat += strat; }
                    mSDef = 85 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 4); stat += strat; }
                    mSpe = 100 + stat;
                    break;
                case 7:
                    mName = "Squirtle";
                    mType = "water";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mMHP = 44 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 48 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 5); stat += strat; }
                    mDef = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSAtk = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSDef = 64 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 2); stat += strat; }
                    mSpe = 43 + stat;
                    break;
                case 8:
                    mName = "Wartortle";
                    mType = "water";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 59 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 63 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 5); stat += strat; }
                    mDef = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSAtk = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSDef = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 2); stat += strat; }
                    mSpe = 58 + stat;
                    break;
                case 9:
                    mName = "Blastoise";
                    mType = "water";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 79 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 83 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 5); stat += strat; }
                    mDef = 100 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSAtk = 85 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 5); stat += strat; }
                    mSDef = 105 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 2); stat += strat; }
                    mSpe = 78 + stat;
                    break;
                case 10:
                    mName = "Caterpie";
                    mType = "bug";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 4); stat += strat; }
                    mMHP = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mAtk = 30 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 4); stat += strat; }
                    mDef = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 20 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 20 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 4); stat += strat; }
                    mSpe = 45 + stat;
                    break;
                case 11:
                    mName = "Metapod";
                    mType = "bug";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 4); stat += strat; }
                    mMHP = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mAtk = 20 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mDef = 55 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 25 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 25 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 4); stat += strat; }
                    mSpe = 30 + stat;
                    break;
                case 12:
                    mName = "Butterfree";
                    mType = "bug/flying";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 4); stat += strat; }
                    mMHP = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mAtk = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mDef = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSAtk = 90 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSDef = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 70 + stat;
                    break;
                case 13:
                    mName = "Weedle";
                    mType = "bug";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 4); stat += strat; }
                    mMHP = 40 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mAtk = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mDef = 30 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 20 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 20 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 4); stat += strat; }
                    mSpe = 50 + stat;
                    break;
                case 14:
                    mName = "Kakuna";
                    mType = "bug/poison";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 4); stat += strat; }
                    mMHP = 40 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mAtk = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mDef = 30 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 20 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 20 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 4); stat += strat; }
                    mSpe = 50 + stat;
                    break;
                case 15:
                    mName = "Beedrill";
                    mType = "bug/poison";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 4); stat += strat; }
                    mMHP = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mAtk = 90 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mDef = 40 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 75 + stat;
                    break;
                case 16:
                    mName = "Pidgey";
                    mType = "normal/flying";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 40 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mAtk = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mDef = 40 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 56 + stat;
                    break;
                case 17:
                    mName = "Pidgeotto";
                    mType = "normal/flying";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 63 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 55 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 71 + stat;
                    break;
                case 18:
                    mName = "Pidgeot";
                    mType = "normal/flying";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 83 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 75 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSAtk = 70 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 70 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 101 + stat;
                    break;
                case 19:
                    mName = "Rattata";
                    mType = "normal";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mMHP = 30 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 56 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mDef = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 25 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 72 + stat;
                    break;
                case 20:
                    mName = "Raticate";
                    mType = "normal";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 55 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mAtk = 81 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 70 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 97 + stat;
                    break;
                case 21:
                    mName = "Spearow";
                    mType = "normal/flying";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mMHP = 40 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mDef = 30 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 31 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 31 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 70 + stat;
                    break;
                case 22:
                    mName = "Fearow";
                    mType = "normal/flying";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mAtk = 90 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSAtk = 61 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 61 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 100 + stat;
                    break;
                case 23:
                    mName = "Ekans";
                    mType = "poison";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mAtk = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mDef = 44 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 40 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 54 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 55 + stat;
                    break;
                case 24:
                    mName = "Arbok";
                    mType = "poison";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mAtk = 95 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 69 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSAtk = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSDef = 79 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 80 + stat;
                    break;
                case 25:
                    mName = "Pikachu";
                    mType = "electric";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 3); stat += strat; }
                    mMHP = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 55 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mDef = 40 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSAtk = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSpe = 90 + stat;
                    break;
                case 26:
                    mName = "Raichu";
                    mType = "electric";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 3); stat += strat; }
                    mMHP = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mAtk = 90 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 55 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSAtk = 90 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSDef = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSpe = 110 + stat;
                    break;
                case 65:
                    mName = "Alakazam";
                    mType = "psychic";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 55 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 5); stat += strat; }
                    mSAtk = 135 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSDef = 95 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSpe = 120 + stat;
                    break;
                case 94:
                    mName = "Gengar";
                    mType = "ghost/poison";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 60 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 5); stat += strat; }
                    mSAtk = 130 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSDef = 75 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSpe = 110 + stat;
                    break;
                case 95:
                    mName = "Onix";
                    mType = "rock/ground";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mMHP = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mAtk = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 5); stat += strat; }
                    mDef = 160 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 30 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 70 + stat;
                    break;
                case 104:
                    mName = "Cubone";
                    mType = "ground";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mDef = 95 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 40 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSpe = 35 + stat;
                    break;
                case 107:
                    mName = "Hitmonchan";
                    mType = "fighting";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 50 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mAtk = 105 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 79 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 2); stat += strat; }
                    mSAtk = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSDef = 110 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 76 + stat;
                    break;
                case 111:
                    mName = "Rhyhorn";
                    mType = "rock/ground";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mAtk = 85 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mDef = 96 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 30 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 30 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSpe = 25 + stat;
                    break;
                case 112:
                    mName = "Rhydon";
                    mType = "rock/ground";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 5); stat += strat; }
                    mMHP = 105 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mAtk = 130 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mDef = 120 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSDef = 45 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSpe = 40 + stat;
                    break;
                case 113:
                    mName = "Chansey";
                    mType = "normal";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(4, 6); stat += strat; }
                    mMHP = 250 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 2); stat += strat; }
                    mAtk = 5 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 2); stat += strat; }
                    mDef = 5 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSAtk = 35 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSDef = 105 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(0, 3); stat += strat; }
                    mSpe = 50 + stat;
                    break;
                case 123:
                    mName = "Scyther";
                    mType = "bug/flying";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 70 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mAtk = 110 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSAtk = 55 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSpe = 105 + stat;
                    break;
                case 131:
                    mName = "Lapras";
                    mType = "water/ice";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(3, 5); stat += strat; }
                    mMHP = 130 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 85 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 80 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSAtk = 85 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 4); stat += strat; }
                    mSDef = 95 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 60 + stat;
                    break;
                case 148:
                    mName = "Dragonair";
                    mType = "dragon";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mMHP = 61 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mAtk = 84 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mDef = 65 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSAtk = 70 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSDef = 70 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(1, 3); stat += strat; }
                    mSpe = 70 + stat;
                    break;
                case 151:
                    mName = "Mew";
                    mType = "mew";
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 5); stat += strat; }
                    mMHP = 100 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mAtk = 100 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mDef = 100 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSAtk = 100 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSDef = 100 + stat;
                    for (int x = 1; x <= lvl; x++) { strat = rng.Next(2, 4); stat += strat; }
                    mSpe = 100 + stat;
                    break;
            }
            mHP = mMHP;
            moveSet = setAttacks(mType);
        }
        public Attack[] setAttacks(string moveType)
        {
            string[] normalMoves = { "Strength", "Headbutt", "Hyper Fang", "Mega Punch" };
            int[] normalPP = { 15, 15, 15, 20 };
            int[] normalPow = { 80, 70, 80, 80 };
            int[] normalAccuracy = { 100, 100, 90, 85 };
            string[] fireMoves = { "Flamethrower", "Flare Blitz", "Blaze Kick", "Fire Punch" };
            int[] firePP = { 15, 15, 10, 15 };
            int[] firePow = { 90, 120, 85, 75 };
            int[] fireAccuracy = { 100, 100, 90, 100 };
            string[] waterMoves = { "Scald", "Razor Shell", "Hydro Pump", "Surf" };
            int[] waterPP = { 15, 10, 5, 15 };
            int[] waterPow = { 80, 75, 110, 90 };
            int[] waterAccuracy = { 100, 95, 80, 100 };
            string[] elecMoves = { "Thunder Punch", "Volt Tackle", "Thunderbolt", "Thunder" };
            int[] elecPP = { 15, 15, 15, 10 };
            int[] elecPow = { 75, 120, 90, 110 };
            int[] elecAccuracy = { 100, 100, 100, 70 };
            string[] grassMoves = { "Giga Drain", "Power Whip", "Leaf Blade", "Trop Kick" };
            int[] grassPP = { 10, 10, 15, 15 };
            int[] grassPow = { 75, 120, 90, 70 };
            int[] grassAccuracy = { 100, 85, 100, 100 };
            string[] iceMoves = { "Ice Hammer", "Icicle Crash", "Blizzard", "Ice Beam" };
            int[] icePP = { 10, 10, 5, 10 };
            int[] icePow = { 100, 85, 110, 95 };
            int[] iceAccuracy = { 90, 90, 90, 100 };
            string[] fightingMoves = { "Jump Kick", "Sky Uppercut", "Focus Punch", "Focus Blast" };
            int[] fightingPP = { 10, 15, 20, 5 };
            int[] fightingPow = { 100, 85, 150, 120 };
            int[] fightingAccuracy = { 95, 90, 100, 70 };
            string[] poisonMoves = { "Gunk Shot", "Poison Fang", "Sludge Bomb", "Sludge Wave" };
            int[] poisonPP = { 5, 15, 10, 10 };
            int[] poisonPow = { 120, 50, 90, 95 };
            int[] poisonAccuracy = { 80, 100, 100, 100 };
            string[] groundMoves = { "Earthquake", "Fissure", "Bulldoze", "Earth Power" };
            int[] groundPP = { 10, 5, 20, 10 };
            int[] groundPow = { 100, int.MaxValue, 60, 90 };
            int[] groundAccuracy = { 100, 30, 100, 100 };
            string[] flyingMoves = { "Brave Bird", "Air Slash", "Hurricane", "Roost" };
            int[] flyingPP = { 15, 15, 10, 10 };
            int[] flyingPow = { 120, 75, 110, 0 };
            int[] flyingAccuracy = { 100, 95, 70, 100 };
            string[] psychicMoves = { "Psychic", "Psystrike", "Psychic Fangs", "Zen Headbutt" };
            int[] psychicPP = { 10, 10, 10, 15 };
            int[] psychicPow = { 90, 100, 85, 80 };
            int[] psychicAccuracy = { 100, 100, 100, 90 };
            string[] bugMoves = { "Bug Bite", "Leech Life", "Skitter Smack", "Bug Buzz" };
            int[] bugPP = { 20, 10, 10, 10 };
            int[] bugPow = { 60, 80, 70, 90 };
            int[] bugAccuracy = { 100, 95, 90, 100 };
            string[] rockMoves = { "Power Gem", "Rock Slide", "Head Smash", "Stone Edge" };
            int[] rockPP = { 20, 10, 5, 5 };
            int[] rockPow = { 80, 75, 150, 100 };
            int[] rockAccuracy = { 100, 90, 80, 80 };
            string[] ghostMoves = { "Shadow Claw", "Shadow Ball", "Hex", "Night Shade" };
            int[] ghostPP = { 15, 15, 10, 15 };
            int[] ghostPow = { 70, 80, 65, 0 };
            int[] ghostAccuracy = { 100, 100, 100, 100 };
            string[] dragonMoves = { "Dragon Rush", "Dragon Claw", "Draco Meteor", "Dragon Pulse" };
            int[] dragonPP = { 10, 15, 5, 10 };
            int[] dragonPow = { 100, 80, 140, 85 };
            int[] dragonAccuracy = { 75, 100, 90, 100 };
            string[] darkMoves = { "Bug Bite", "Leech Life", "Skitter Smack", "Bug Buzz" };
            int[] darkPP = { 20, 10, 10, 10 };
            int[] darkPow = { 60, 80, 70, 90 };
            int[] darkAccuracy = { 100, 95, 90, 100 };
            string[] steelMoves = { "Flash Cannon", "Iron Tail", "Meteor Mash", "Iron Head" };
            int[] steelPP = { 10, 15, 10, 15 };
            int[] steelPow = { 80, 100, 90, 80 };
            int[] steelAccuracy = { 100, 75, 90, 100 };
            string[] fairyMoves = { "Dazzling Gleam", "Fleur Cannon", "Light of Ruin", "Play Rough" };
            int[] fairyPP = { 10, 5, 5, 10 };
            int[] fairyPow = { 80, 130, 140, 90 };
            int[] fairyAccuracy = { 100, 85, 90, 90 };

            Attack[] yeet = new Attack[4];
            Random rng = new Random();
            int poisonV = 0;
            int num1 = rng.Next(0, 4);
            int num2 = rng.Next(0, 4);
            int num3 = rng.Next(0, 4);
            int num4 = rng.Next(0, 4);
            while (num2 == num1)
                num2 = rng.Next(0, 4);
            while (num3 == num2 || num3 == num1)
                num3 = rng.Next(0, 4);
            while (num4 == num3 || num4 == num2 || num4 == num1)
                num4 = rng.Next(0, 4);
            switch (moveType)
            {
                case "fire":
                    yeet[0] = new Attack("fire", num1 != 0 ? "phys" : "spec", fireMoves[num1], firePow[num1], firePP[num1], fireAccuracy[num1]);
                    yeet[1] = new Attack("fire", num2 != 0 ? "phys" : "spec", fireMoves[num2], firePow[num2], firePP[num2], fireAccuracy[num2]);
                    break;
                case "grass":
                    yeet[0] = new Attack("grass", num1 != 0 ? "phys" : "spec", grassMoves[num1], grassPow[num1], grassPP[num1], grassAccuracy[num1]);
                    yeet[1] = new Attack("grass", num2 != 0 ? "phys" : "spec", grassMoves[num2], grassPow[num2], grassPP[num2], grassAccuracy[num2]);
                    break;
                case "water":
                    yeet[0] = new Attack("water", num1 == 1 ? "phys" : "spec", waterMoves[num1], waterPow[num1], waterPP[num1], waterAccuracy[num1]);
                    yeet[1] = new Attack("water", num2 == 1 ? "phys" : "spec", waterMoves[num2], waterPow[num2], waterPP[num2], waterAccuracy[num2]);
                    break;
                case "electric":
                    yeet[0] = new Attack("electric", num1 <= 1 ? "phys" : "spec", elecMoves[num1], elecPow[num1], elecPP[num1], elecAccuracy[num1]);
                    yeet[1] = new Attack("electric", num2 <= 1 ? "phys" : "spec", elecMoves[num2], elecPow[num2], elecPP[num2], elecAccuracy[num2]);
                    break;
                case "ice":
                    yeet[0] = new Attack("ice", num1 <= 1 ? "phys" : "spec", iceMoves[num1], icePow[num1], icePP[num1], iceAccuracy[num1]);
                    yeet[1] = new Attack("ice", num2 <= 1 ? "phys" : "spec", iceMoves[num2], icePow[num2], icePP[num2], iceAccuracy[num2]);
                    break;
                case "bug":
                    yeet[0] = new Attack("bug", num1 <= 2 ? "phys" : "spec", bugMoves[num1], bugPow[num1], bugPP[num1], bugAccuracy[num1]);
                    yeet[1] = new Attack("bug", num2 <= 2 ? "phys" : "spec", bugMoves[num2], bugPow[num2], bugPP[num2], bugAccuracy[num2]);
                    break;
                case "poison":
                    yeet[0] = new Attack("poison", num1 <= 1 ? "phys" : "spec", poisonMoves[num1], poisonPow[num1], poisonPP[num1], poisonAccuracy[num1], poisonV != 3 ? 30 : 10);
                    yeet[1] = new Attack("poison", num2 <= 1 ? "phys" : "spec", poisonMoves[num2], poisonPow[num2], poisonPP[num2], poisonAccuracy[num2], poisonV != 3 ? 30 : 10);
                    break;
                case "flying":
                    yeet[0] = new Attack("flying", num1 == 1 ? "phys" : "spec", flyingMoves[num1], flyingPow[num1], flyingPP[num1], flyingAccuracy[num1]);
                    yeet[1] = new Attack("flying", num2 == 1 ? "phys" : "spec", flyingMoves[num2], flyingPow[num2], flyingPP[num2], flyingAccuracy[num2]);
                    break;
                case "fighting":
                    yeet[0] = new Attack("fighting", num1 != 3 ? "phys" : "spec", fightingMoves[num1], fightingPow[num1], fightingPP[num1], fightingAccuracy[num1]);
                    yeet[1] = new Attack("fighting", num2 != 3 ? "phys" : "spec", fightingMoves[num2], fightingPow[num2], fightingPP[num2], fightingAccuracy[num2]);
                    break;
                case "ground":
                    yeet[0] = new Attack("ground", num1 != 3 ? "phys" : "spec", groundMoves[num1], groundPow[num1], groundPP[num1], groundAccuracy[num1]);
                    yeet[1] = new Attack("ground", num2 != 3 ? "phys" : "spec", groundMoves[num2], groundPow[num2], groundPP[num2], groundAccuracy[num2]);
                    break;
                case "dark":
                    yeet[0] = new Attack("dark", num1 <= 1 ? "phys" : "spec", darkMoves[num1], darkPow[num1], darkPP[num1], darkAccuracy[num1]);
                    yeet[1] = new Attack("dark", num2 <= 1 ? "phys" : "spec", darkMoves[num2], darkPow[num2], darkPP[num2], darkAccuracy[num2]);
                    break;
                case "rock":
                    yeet[0] = new Attack("rock", num1 <= 1 ? "phys" : "spec", rockMoves[num1], rockPow[num1], rockPP[num1], rockAccuracy[num1]);
                    yeet[1] = new Attack("rock", num2 <= 1 ? "phys" : "spec", rockMoves[num2], rockPow[num2], rockPP[num2], rockAccuracy[num2]);
                    break;
                case "dragon":
                    yeet[0] = new Attack("dragon", num1 <= 1 ? "phys" : "spec", dragonMoves[num1], dragonPow[num1], dragonPP[num1], dragonAccuracy[num1]);
                    yeet[1] = new Attack("dragon", num2 <= 1 ? "phys" : "spec", dragonMoves[num2], dragonPow[num2], dragonPP[num2], dragonAccuracy[num2]);
                    break;
                case "steel":
                    yeet[0] = new Attack("steel", num1 != 0 ? "phys" : "spec", steelMoves[num1], steelPow[num1], steelPP[num1], steelAccuracy[num1]);
                    yeet[1] = new Attack("steel", num2 != 0 ? "phys" : "spec", steelMoves[num2], steelPow[num2], steelPP[num2], steelAccuracy[num2]);
                    break;
                case "fairy":
                    yeet[0] = new Attack("fairy", num1 != 3 ? "phys" : "spec", fairyMoves[num1], fairyPow[num1], fairyPP[num1], fairyAccuracy[num1]);
                    yeet[1] = new Attack("fairy", num2 != 3 ? "phys" : "spec", fairyMoves[num2], fairyPow[num2], fairyPP[num2], fairyAccuracy[num2]);
                    break;
                case "ghost":
                    yeet[0] = new Attack("ghost", num1 == 0 ? "phys" : "spec", ghostMoves[num1], ghostPow[num1], ghostPP[num1], ghostAccuracy[num1]);
                    yeet[1] = new Attack("ghost", num2 == 0 ? "phys" : "spec", ghostMoves[num2], ghostPow[num2], ghostPP[num2], ghostAccuracy[num2]);
                    num1 = rng.Next(0, 4);
                    num2 = rng.Next(0, 4);
                    while (num2 == num1)
                        num2 = rng.Next(0, 4);
                    yeet[2] = new Attack("dark", num1 <= 1 ? "phys" : "spec", darkMoves[num1], darkPow[num1], darkPP[num1], darkAccuracy[num1]);
                    yeet[3] = new Attack("normal", "phys", normalMoves[num4], normalPow[num4], normalPP[num4], normalAccuracy[num4]);
                    break;
                case "psychic":
                    yeet[0] = new Attack("psychic", num1 > 1 ? "phys" : "spec", psychicMoves[num1], psychicPow[num1], psychicPP[num1], psychicAccuracy[num1]);
                    yeet[1] = new Attack("psychic", num2 > 1 ? "phys" : "spec", psychicMoves[num2], psychicPow[num2], psychicPP[num2], psychicAccuracy[num2]);
                    yeet[2] = new Attack("psychic", num3 > 1 ? "phys" : "spec", psychicMoves[num3], psychicPow[num3], psychicPP[num3], psychicAccuracy[num3]);
                    yeet[3] = new Attack("normal", "phys", normalMoves[num4], normalPow[num4], normalPP[num4], normalAccuracy[num4]);
                    break;
                case "fire/flying":
                    yeet[0] = new Attack("fire", num1 != 0 ? "phys" : "spec", fireMoves[num1], firePow[num1], firePP[num1], fireAccuracy[num1]);
                    yeet[1] = new Attack("flying", num2 == 1 ? "phys" : "spec", flyingMoves[num2], flyingPow[num2], flyingPP[num2], flyingAccuracy[num2]);
                    break;
                case "rock/water":
                    yeet[0] = new Attack("water", num1 == 1 ? "phys" : "spec", waterMoves[num1], waterPow[num1], waterPP[num1], waterAccuracy[num1]);
                    yeet[1] = new Attack("rock", num2 <= 1 ? "phys" : "spec", rockMoves[num2], rockPow[num2], rockPP[num2], rockAccuracy[num2]);
                    break;
                case "water/fighting":
                    yeet[0] = new Attack("water", num1 == 1 ? "phys" : "spec", waterMoves[num1], waterPow[num1], waterPP[num1], waterAccuracy[num1]);
                    yeet[1] = new Attack("flying", num2 == 1 ? "phys" : "spec", flyingMoves[num2], flyingPow[num2], flyingPP[num2], flyingAccuracy[num2]);
                    break;
                case "water/pyschic":
                    yeet[0] = new Attack("water", num1 == 1 ? "phys" : "spec", waterMoves[num1], waterPow[num1], waterPP[num1], waterAccuracy[num1]);
                    yeet[1] = new Attack("psychic", num2 > 1 ? "phys" : "spec", psychicMoves[num2], psychicPow[num2], psychicPP[num2], psychicAccuracy[num2]);
                    yeet[2] = new Attack("psychic", num3 > 1 ? "phys" : "spec", psychicMoves[num3], psychicPow[num3], psychicPP[num3], psychicAccuracy[num3]);
                    yeet[3] = new Attack("normal", "phys", normalMoves[num4], normalPow[num4], normalPP[num4], normalAccuracy[num4]);
                    break;
                case "ice/pyschic":
                    yeet[0] = new Attack("ice", num1 <= 1 ? "phys" : "spec", iceMoves[num1], icePow[num1], icePP[num1], iceAccuracy[num1]);
                    yeet[1] = new Attack("psychic", num2 > 1 ? "phys" : "spec", psychicMoves[num2], psychicPow[num2], psychicPP[num2], psychicAccuracy[num2]);
                    yeet[2] = new Attack("psychic", num3 > 1 ? "phys" : "spec", psychicMoves[num3], psychicPow[num3], psychicPP[num3], psychicAccuracy[num3]);
                    yeet[3] = new Attack("normal", "phys", normalMoves[num4], normalPow[num4], normalPP[num4], normalAccuracy[num4]);
                    break;
                case "psyschic/fairy":
                    yeet[0] = new Attack("fairy", num1 != 3 ? "phys" : "spec", fairyMoves[num1], fairyPow[num1], fairyPP[num1], fairyAccuracy[num1]);
                    yeet[1] = new Attack("psychic", num2 > 1 ? "phys" : "spec", psychicMoves[num2], psychicPow[num2], psychicPP[num2], psychicAccuracy[num2]);
                    yeet[2] = new Attack("psychic", num3 > 1 ? "phys" : "spec", psychicMoves[num3], psychicPow[num3], psychicPP[num3], psychicAccuracy[num3]);
                    yeet[3] = new Attack("normal", "phys", normalMoves[num4], normalPow[num4], normalPP[num4], normalAccuracy[num4]);
                    break;
                case "water/poison":
                    yeet[0] = new Attack("water", num1 == 1 ? "phys" : "spec", waterMoves[num1], waterPow[num1], waterPP[num1], waterAccuracy[num1]);
                    yeet[1] = new Attack("poison", num2 <= 1 ? "phys" : "spec", poisonMoves[num2], poisonPow[num2], poisonPP[num2], poisonAccuracy[num2], poisonV != 3 ? 30 : 10);
                    break;
                case "bug/flying":
                    yeet[0] = new Attack("bug", num1 <= 2 ? "phys" : "spec", bugMoves[num1], bugPow[num1], bugPP[num1], bugAccuracy[num1]);
                    yeet[1] = new Attack("flying", num2 == 1 ? "phys" : "spec", flyingMoves[num2], flyingPow[num2], flyingPP[num2], flyingAccuracy[num2]);
                    break;
                case "bug/poison":
                    yeet[0] = new Attack("bug", num1 <= 2 ? "phys" : "spec", bugMoves[num1], bugPow[num1], bugPP[num1], bugAccuracy[num1]);
                    yeet[1] = new Attack("poison", num2 <= 1 ? "phys" : "spec", poisonMoves[num2], poisonPow[num2], poisonPP[num2], poisonAccuracy[num2], poisonV != 3 ? 30 : 10);
                    break;
                case "bug/grass":
                    yeet[0] = new Attack("bug", num1 <= 2 ? "phys" : "spec", bugMoves[num1], bugPow[num1], bugPP[num1], bugAccuracy[num1]);
                    yeet[1] = new Attack("grass", num2 != 0 ? "phys" : "spec", grassMoves[num2], grassPow[num2], grassPP[num2], grassAccuracy[num2]);
                    break;
                case "grass/poison":
                    yeet[0] = new Attack("poison", num1 <= 1 ? "phys" : "spec", poisonMoves[num1], poisonPow[num1], poisonPP[num1], poisonAccuracy[num1], poisonV != 3 ? 30 : 10);
                    yeet[1] = new Attack("grass", num2 != 0 ? "phys" : "spec", grassMoves[num2], grassPow[num2], grassPP[num2], grassAccuracy[num2]);
                    break;
                case "grass/psychic":
                    yeet[0] = new Attack("grass", num1 != 0 ? "phys" : "spec", grassMoves[num1], grassPow[num1], grassPP[num1], grassAccuracy[num1]);
                    yeet[1] = new Attack("psychic", num2 > 1 ? "phys" : "spec", psychicMoves[num2], psychicPow[num2], psychicPP[num2], psychicAccuracy[num2]);
                    yeet[2] = new Attack("psychic", num3 > 1 ? "phys" : "spec", psychicMoves[num3], psychicPow[num3], psychicPP[num3], psychicAccuracy[num3]);
                    yeet[3] = new Attack("normal", "phys", normalMoves[num4], normalPow[num4], normalPP[num4], normalAccuracy[num4]);
                    break;
                case "normal/flying":
                    yeet[0] = new Attack("flying", num1 == 1 ? "phys" : "spec", flyingMoves[num1], flyingPow[num1], flyingPP[num1], flyingAccuracy[num1]);
                    yeet[1] = new Attack("flying", num2 == 1 ? "phys" : "spec", flyingMoves[num2], flyingPow[num2], flyingPP[num2], flyingAccuracy[num2]);
                    break;
                case "water/ice":
                    yeet[0] = new Attack("water", num1 == 1 ? "phys" : "spec", waterMoves[num1], waterPow[num1], waterPP[num1], waterAccuracy[num1]);
                    yeet[1] = new Attack("water", num2 == 1 ? "phys" : "spec", waterMoves[num2], waterPow[num2], waterPP[num2], waterAccuracy[num2]);
                    num1 = rng.Next(0, 4);
                    num2 = rng.Next(0, 4);
                    while (num2 == num1)
                        num2 = rng.Next(0, 4);
                    yeet[2] = new Attack("ice", num1 <= 1 ? "phys" : "spec", iceMoves[num1], icePow[num1], icePP[num1], iceAccuracy[num1]);
                    yeet[3] = new Attack("ice", num2 <= 1 ? "phys" : "spec", iceMoves[num2], icePow[num2], icePP[num2], iceAccuracy[num2]);
                    break;
                case "electric/steel":
                    yeet[0] = new Attack("electric", num1 <= 1 ? "phys" : "spec", elecMoves[num1], elecPow[num1], elecPP[num1], elecAccuracy[num1]);
                    yeet[1] = new Attack("electric", num2 <= 1 ? "phys" : "spec", elecMoves[num2], elecPow[num2], elecPP[num2], elecAccuracy[num2]);
                    num1 = rng.Next(0, 4);
                    num2 = rng.Next(0, 4);
                    while (num2 == num1)
                        num2 = rng.Next(0, 4);
                    yeet[2] = new Attack("steel", num1 != 0 ? "phys" : "spec", steelMoves[num1], steelPow[num1], steelPP[num1], steelAccuracy[num1]);
                    yeet[3] = new Attack("steel", num2 != 0 ? "phys" : "spec", steelMoves[num2], steelPow[num2], steelPP[num2], steelAccuracy[num2]);
                    break;
                case "ghost/poison":
                    yeet[0] = new Attack("ghost", num1 == 0 ? "phys" : "spec", ghostMoves[num1], ghostPow[num1], ghostPP[num1], ghostAccuracy[num1]);
                    yeet[1] = new Attack("ghost", num2 == 0 ? "phys" : "spec", ghostMoves[num2], ghostPow[num2], ghostPP[num2], ghostAccuracy[num2]);
                    num1 = rng.Next(0, 4);
                    num2 = rng.Next(0, 4);
                    while (num2 == num1)
                        num2 = rng.Next(0, 4);
                    yeet[2] = new Attack("dark", num1 <= 1 ? "phys" : "spec", darkMoves[num1], darkPow[num1], darkPP[num1], darkAccuracy[num1]);
                    yeet[3] = new Attack("poison", num2 <= 1 ? "phys" : "spec", poisonMoves[num2], poisonPow[num2], poisonPP[num2], poisonAccuracy[num2], poisonV != 3 ? 30 : 10);
                    break;
                case "rock/ground":
                    yeet[0] = new Attack("rock", num1 <= 1 ? "phys" : "spec", rockMoves[num1], rockPow[num1], rockPP[num1], rockAccuracy[num1]);
                    yeet[1] = new Attack("rock", num2 <= 1 ? "phys" : "spec", rockMoves[num2], rockPow[num2], rockPP[num2], rockAccuracy[num2]);
                    num1 = rng.Next(0, 4);
                    num2 = rng.Next(0, 4);
                    while (num2 == num1)
                        num2 = rng.Next(0, 4);
                    yeet[2] = new Attack("ground", num1 != 3 ? "phys" : "spec", groundMoves[num1], groundPow[num1], groundPP[num1], groundAccuracy[num1]);
                    yeet[3] = new Attack("ground", num2 != 3 ? "phys" : "spec", groundMoves[num2], groundPow[num2], groundPP[num2], groundAccuracy[num2]);
                    break;
                case "poison/ground":
                    yeet[0] = new Attack("poison", num1 <= 1 ? "phys" : "spec", poisonMoves[num1], poisonPow[num1], poisonPP[num1], poisonAccuracy[num1], poisonV != 3 ? 30 : 10);
                    yeet[1] = new Attack("poison", num2 <= 1 ? "phys" : "spec", poisonMoves[num2], poisonPow[num2], poisonPP[num2], poisonAccuracy[num2], poisonV != 3 ? 30 : 10);
                    num1 = rng.Next(0, 4);
                    num2 = rng.Next(0, 4);
                    while (num2 == num1)
                        num2 = rng.Next(0, 4);
                    yeet[2] = new Attack("ground", num1 != 3 ? "phys" : "spec", groundMoves[num1], groundPow[num1], groundPP[num1], groundAccuracy[num1]);
                    yeet[3] = new Attack("ground", num2 != 3 ? "phys" : "spec", groundMoves[num2], groundPow[num2], groundPP[num2], groundAccuracy[num2]);
                    break;
                case "poison/flying":
                    yeet[0] = new Attack("poison", num1 <= 1 ? "phys" : "spec", poisonMoves[num1], poisonPow[num1], poisonPP[num1], poisonAccuracy[num1], poisonV != 3 ? 30 : 10);
                    yeet[1] = new Attack("poison", num2 <= 1 ? "phys" : "spec", poisonMoves[num2], poisonPow[num2], poisonPP[num2], poisonAccuracy[num2], poisonV != 3 ? 30 : 10);
                    num1 = rng.Next(0, 4);
                    num2 = rng.Next(0, 4);
                    while (num2 == num1)
                        num2 = rng.Next(0, 4);
                    yeet[2] = new Attack("flying", num1 == 1 ? "phys" : "spec", flyingMoves[num1], flyingPow[num1], flyingPP[num1], flyingAccuracy[num1]);
                    yeet[3] = new Attack("normal", "phys", normalMoves[num2], normalPow[num2], normalPP[num2], normalAccuracy[num2]);
                    break;
                case "normal":
                    yeet[0] = new Attack("normal", "phys", normalMoves[num1], normalPow[num1], normalPP[num1], normalAccuracy[num1]);
                    yeet[1] = new Attack("normal", "phys", normalMoves[num2], normalPow[num2], normalPP[num2], normalAccuracy[num2]);
                    yeet[2] = new Attack("normal", "phys", normalMoves[num3], normalPow[num3], normalPP[num3], normalAccuracy[num3]);
                    yeet[3] = new Attack("normal", "phys", normalMoves[num4], normalPow[num4], normalPP[num4], normalAccuracy[num4]);
                    break;
                case "mew":
                    yeet[0] = new Attack("grass", num1 != 0 ? "phys" : "spec", grassMoves[num1], grassPow[num1], grassPP[num1], grassAccuracy[num1]);
                    yeet[1] = new Attack("water", num2 == 1 ? "phys" : "spec", waterMoves[num2], waterPow[num2], waterPP[num2], waterAccuracy[num2]);
                    num1 = rng.Next(0, 4);
                    num2 = rng.Next(0, 4);
                    while (num2 == num1)
                        num2 = rng.Next(0, 4);
                    yeet[2] = new Attack("fire", num1 != 0 ? "phys" : "spec", fireMoves[num1], firePow[num1], firePP[num1], fireAccuracy[num1]);
                    yeet[3] = new Attack("normal", "phys", normalMoves[num2], normalPow[num2], normalPP[num2], normalAccuracy[num2]);
                    break;
            }
            if (yeet[3] == null)
            {
                num1 = rng.Next(0, 4);
                num2 = rng.Next(0, 4);
                while (num2 == num1)
                    num2 = rng.Next(0, 4);
                yeet[2] = new Attack("normal", "phys", normalMoves[num1], normalPow[num1], normalPP[num1], normalAccuracy[num1]);
                yeet[3] = new Attack("normal", "phys", normalMoves[num2], normalPow[num2], normalPP[num2], normalAccuracy[num2]);
            }
            return yeet;
        }
        public void Hit(Monster other,Attack atk)//opponent pokemon and their attack on eachother
        {
            double effective = 1;//default effectivew ness
            int power = atk.Power;
            if (other.poison && atk.Name.Equals("Hex"))
                power *= 2;
            //checks if the move type would be extra or less effective on the attacked pokemon
            //super effective (used Contains for combo types but no x4 stuff because yikes)
            if (((other.mType.Contains("grass") || other.mType.Contains("ice") || other.mType.Contains("bug") || other.mType.Contains("steel")) && atk.MType.Equals("fire"))/*fire*/ || ((other.mType.Contains("fire") || other.mType.Contains("ground") || other.mType.Contains("rock")) && atk.MType.Equals("water"))/*water*/ || ((other.mType.Contains("water") || other.mType.Contains("flying")) && atk.MType.Equals("electric"))/*electric*/  || ((other.mType.Contains("water") || other.mType.Contains("ground") || other.mType.Contains("rock")) && atk.MType.Equals("grass"))/*grass*/ || ((other.mType.Contains("grass") || other.mType.Contains("ground") || other.mType.Contains("flying") || other.mType.Contains("dragon")) && atk.MType.Equals("ice"))/*ice*/ || ((other.mType.Contains("normal") || other.mType.Contains("ice") || other.mType.Contains("rock") || other.mType.Contains("dark") || other.mType.Contains("steel")) && atk.MType.Equals("fighting"))/*fighting*/ || ((other.mType.Contains("grass") || other.mType.Contains("fairy")) && atk.MType.Equals("poison"))/*poison*/ || ((other.mType.Contains("fire") || other.mType.Contains("electric") || other.mType.Contains("poison") || other.mType.Contains("rock") || other.mType.Contains("steel")) && atk.MType.Equals("ground"))/*ground*/ || ((other.mType.Contains("grass") || other.mType.Contains("bug") || other.mType.Contains("fighting")) && atk.MType.Equals("flying"))/*flying*/ || ((other.mType.Contains("poison") || other.mType.Contains("fighting")) && atk.MType.Equals("psychic"))/*psychic*/ || ((other.mType.Contains("grass") || other.mType.Contains("psychic") || other.mType.Contains("dark")) && atk.MType.Equals("bug"))/*bug*/ || ((other.mType.Contains("fire") || other.mType.Contains("ice") || other.mType.Contains("flying") || other.mType.Contains("bug")) && atk.MType.Equals("rock"))/*rock*/ || ((other.mType.Contains("psychic") || other.mType.Contains("ghost")) && atk.MType.Equals("ghost"))/*ghost*/ || ((other.mType.Contains("dragon")) && atk.MType.Equals("dragon"))/*dragon*/ || ((other.mType.Contains("psychic") || other.mType.Contains("ghost")) && atk.MType.Equals("dark"))/*dark*/ || ((other.mType.Contains("ice") || other.mType.Contains("rock") || other.mType.Contains("fairy")) && atk.MType.Equals("steel"))/*steel*/ || ((other.mType.Contains("dragon") || other.mType.Contains("dark") || other.mType.Contains("fighting")) && atk.MType.Equals("fairy"))/*fairy*/)
                effective *= 2;
            //checks type combo
            if (other.mType.Contains("/") && (((other.mType.Contains("grass") || other.mType.Contains("ice") || other.mType.Contains("bug") || other.mType.Contains("steel")) && atk.MType.Equals("fire"))/*fire*/ || ((other.mType.Contains("fire") || other.mType.Contains("ground") || other.mType.Contains("rock")) && atk.MType.Equals("water"))/*water*/ || ((other.mType.Contains("water") || other.mType.Contains("flying")) && atk.MType.Equals("electric"))/*electric*/  || ((other.mType.Contains("water") || other.mType.Contains("ground") || other.mType.Contains("rock")) && atk.MType.Equals("grass"))/*grass*/ || ((other.mType.Contains("grass") || other.mType.Contains("ground") || other.mType.Contains("flying") || other.mType.Contains("dragon")) && atk.MType.Equals("ice"))/*ice*/ || ((other.mType.Contains("normal") || other.mType.Contains("ice") || other.mType.Contains("rock") || other.mType.Contains("dark") || other.mType.Contains("steel")) && atk.MType.Equals("fighting"))/*fighting*/ || ((other.mType.Contains("grass") || other.mType.Contains("fairy")) && atk.MType.Equals("poison"))/*poison*/ || ((other.mType.Contains("fire") || other.mType.Contains("electric") || other.mType.Contains("poison") || other.mType.Contains("rock") || other.mType.Contains("steel")) && atk.MType.Equals("ground"))/*ground*/ || ((other.mType.Contains("grass") || other.mType.Contains("bug") || other.mType.Contains("fighting")) && atk.MType.Equals("flying"))/*flying*/ || ((other.mType.Contains("poison") || other.mType.Contains("fighting")) && atk.MType.Equals("psychic"))/*psychic*/ || ((other.mType.Contains("grass") || other.mType.Contains("psychic") || other.mType.Contains("dark")) && atk.MType.Equals("bug"))/*bug*/ || ((other.mType.Contains("fire") || other.mType.Contains("ice") || other.mType.Contains("flying") || other.mType.Contains("bug")) && atk.MType.Equals("rock"))/*rock*/ || ((other.mType.Contains("psychic") || other.mType.Contains("ghost")) && atk.MType.Equals("ghost"))/*ghost*/ || ((other.mType.Contains("dragon")) && atk.MType.Equals("dragon"))/*dragon*/ || ((other.mType.Contains("psychic") || other.mType.Contains("ghost")) && atk.MType.Equals("dark"))/*dark*/ || ((other.mType.Contains("ice") || other.mType.Contains("rock") || other.mType.Contains("fairy")) && atk.MType.Equals("steel"))/*steel*/ || ((other.mType.Contains("dragon") || other.mType.Contains("dark") || other.mType.Contains("fighting")) && atk.MType.Equals("fairy"))/*fairy*/))
                effective *= 2;
            //not very effective multiplier
            if (((other.mType.Contains("rock") || other.mType.Contains("steel")) && atk.MType.Equals("normal"))/*normal*/ || ((other.mType.Contains("fire") || other.mType.Contains("water") || other.mType.Contains("rock") || other.mType.Contains("dragon")) && atk.MType.Equals("fire"))/*fire*/ || ((other.mType.Contains("water") || other.mType.Contains("grass") || other.mType.Contains("dragon")) && atk.MType.Equals("water"))/*water*/ || ((other.mType.Contains("electric") || other.mType.Contains("grass") || other.mType.Contains("dragon")) && atk.MType.Equals("electric"))/*electric*/ || ((other.mType.Contains("fire") || other.mType.Contains("grass") || other.mType.Contains("poison") || other.mType.Contains("flying") || other.mType.Contains("bug") || other.mType.Contains("dragon") || other.mType.Contains("steel")) && atk.MType.Equals("grass"))/*grass*/ || ((other.mType.Contains("fire") || other.mType.Contains("water") || other.mType.Contains("ice") || other.mType.Contains("steel")) && atk.MType.Equals("ice"))/*ice*/ || ((other.mType.Contains("poison") || other.mType.Contains("flying") || other.mType.Contains("psychic") || other.mType.Contains("bug") || other.mType.Contains("fairy")) && atk.MType.Equals("fighting"))/*fighting*/ || ((other.mType.Contains("poison") || other.mType.Contains("ground") || other.mType.Contains("rock") || other.mType.Contains("ghost")) && atk.MType.Equals("poison"))/*poison*/ || ((other.mType.Contains("grass") || other.mType.Contains("bug")) && atk.MType.Equals("rock"))/*ground*/ || ((other.mType.Contains("electric") || other.mType.Contains("rock") || other.mType.Contains("steel")) && atk.MType.Equals("flying"))/*flying*/ || ((other.mType.Contains("psychic") || other.mType.Contains("steel")) && atk.MType.Equals("psychic"))/*psychic*/ || ((other.mType.Contains("fire") || other.mType.Contains("fighting") || other.mType.Contains("poison") || other.mType.Contains("flying") || other.mType.Contains("ghost") || other.mType.Contains("steel") || other.mType.Contains("fairy")) && atk.MType.Equals("bug"))/*bug*/ || ((other.mType.Contains("fighting") || other.mType.Contains("ground") || other.mType.Contains("steel")) && atk.MType.Equals("rock"))/*rock*/ || ((other.mType.Contains("dark")) && atk.MType.Equals("ghost"))/*ghost*/ || ((other.mType.Contains("steel")) && atk.MType.Equals("dragon"))/*dragon*/ || ((other.mType.Contains("fighting") || other.mType.Contains("dark") || other.mType.Contains("fairy")) && atk.MType.Equals("dark"))/*dark*/ || ((other.mType.Contains("fire") || other.mType.Contains("water") || other.mType.Contains("electric") || other.mType.Contains("steel")) && atk.MType.Equals("steel"))/*steel*/ || ((other.mType.Contains("fire") || other.mType.Contains("poison") || other.mType.Contains("steel")) && atk.MType.Equals("fairy"))/*fairy*/)
                effective *= .5;
            if ((other.mType.Contains("fairy") && atk.MType.Equals("dragon"))/*dragon*/ || (other.mType.Contains("normal") && atk.MType.Equals("ghost"))/*ghost*/ || (other.mType.Contains("dark") && atk.MType.Equals("psychic"))/*psychic*/ || (other.mType.Contains("flying") && atk.MType.Equals("ground"))/*ground*/ || (other.mType.Contains("ghost") && atk.MType.Equals("fighting"))/*fighting*/ || (other.mType.Contains("ground") && atk.MType.Equals("electric"))/*electric*/ || (other.mType.Contains("ghost") && atk.MType.Equals("normal"))/*normal*/)
                effective *= 0;

            //actual damage variable
            double damage = 0.0;

            //official pokemon damage equation
            if (atk.AType.Equals("phys"))
            { damage = ((((((2.0 * this.mLvl) / 5) + 2) * power * ((double)this.mAtk / other.mDef)) / 50.0) + 2) * effective; }
            else
            { damage = ((((((2.0 * this.mLvl) / 5) + 2) * power * ((double)this.mSAtk / other.mSDef)) / 50.0) + 2) * effective; }
            if (atk.Name.Equals("Night Shade"))
                damage = this.mLvl;
            if (atk.Name.Equals("Fissure"))
                damage = other.getMHP();
            other.mHP -= (int)damage;//actually deals the damage
            this.mHP -= (int)Math.Ceiling(damage * atk.Recoil());//calcs recoil damage/health
            
            //special healing moves 
            if (atk.Name.Equals("Roost"))
                this.mHP += this.mMHP / 2;
            atk.PP--;
            
            //sets up message for effectiveness of move
            string effMes = "";//default for no special effectiveness
            if (effective == 0)
                effMes ="The attack wasn't effective!";
            else if (effective == .5)
                effMes = "The attack wasn't very effective!";
            else if (effective == 2)
                effMes = "The attack was supper effective!";

            //Checks and sets poison effect
            Random rng = new Random();
            int poisonPercent = rng.Next(1,101);
            if (poisonPercent<=atk.Poison) //random rolled number has to be inside 1 to poison moves percent
            {
                effMes += $"{other.getName()} has been poisoned.";
                other.poison = true;
            }

            // makes sure health doesn't escape max and min values
            if (this.mHP > this.mMHP)
                this.mHP = this.mMHP;
            if (other.mHP < 0)
                other.mHP = 0;
            Console.SetCursorPosition(1, (Console.WindowHeight / 3) * 2);
            Console.WriteLine($"{this.mName} hit {other.mName} with {atk.Name}! {effMes}");
            Console.ReadKey();
        }
        public void TryAttack(Monster other, Attack atk)
        {
            Random hitChance = new Random();
            int hChance = hitChance.Next(1, 101);
            if (hChance <= atk.Accuracy)
            {
                Hit(other, atk);
            }
            else
            {
                Console.SetCursorPosition(1, (Console.WindowHeight / 3) * 2);
                Console.WriteLine($"{other.mName} dodged {this.mName}'s {atk.Name}!");
                atk.PP--;
                Console.ReadKey();
            }
        }

        public Attack getMove(int x)
        {
            return moveSet[x];
        }
        public string getName()
        {
            return mName;
        }
        public string getType()
        {
            return mType;
        }
        public int getSpeed()
        {
            return mSpe;
        }
        public string dispHP()
        {
            return mHP+"/"+mMHP;
        }
        public int getLvl()
        {
            return mLvl;
        }
        public int getHP()
        {
            return mHP;
        }
        public int getMHP()
        {
            return mMHP;
        }
        public void setHP(int value)
        {
            mHP=value;
        }
        public bool poison
        {
            get { return poisoned; }
            set { poisoned = value; }
        }
        public void infoBox(int x,int y)
        {
            Console.SetCursorPosition(x, y++);
            Console.Write("_________________________");
            Console.SetCursorPosition(x, y++);
            Console.Write($"|{mName}\t LVL: {mLvl}");
            Console.SetCursorPosition(x, y++);
            Console.Write($"|");
            Console.SetCursorPosition(x, y++);
            Console.Write($"|Health: {this.dispHP()}");
        }
    }

    class Attack
    {
        private string mMType, mAType, mName;
        private int mPower, mPP, mMPP, mAccuracy,mPoisonP=0;
        private double mHurt;


        public Attack(string mtype, string atype, string name, int power, int pp, int accuracy)
        {
            mMType = mtype;
            mAType = atype;
            mName = name;
            mPower = power;
            mMPP = pp;
            mPP = mMPP;
            mAccuracy = accuracy;
            if (name.Equals("Flare Blitz") || name.Equals("Volt Tackle") || name.Equals("Brave Bird"))
                mHurt = .333;
            else if (name.Equals("Head Smash") || name.Equals("Light of Ruin"))
                mHurt = .5;
            else if (name.Equals("Giga Drain") || name.Equals("Leech Life"))
                mHurt = -.5;
            else
                mHurt = 0;
        }
        public Attack(string mtype, string atype, string name, int power, int pp, int accuracy,int pPercent)
        {
            mMType = mtype;
            mAType = atype;
            mName = name;
            mPower = power;
            mMPP = pp;
            mPP = mMPP;
            mAccuracy = accuracy;
            mPoisonP = pPercent;
        }

        public double Recoil()
        {
            return mHurt;
        }
        public int Power
        {
            get
            {
                return mPower;
            }
            set
            {
                mPower = value;
            }
        }

        public int PP
        {
            get
            {
                return mPP;
            }
            set
            {
                mPP = value;
            }
        }

        public string disPP() { return mPP + "/" + mMPP; }

        public string MType
        {
            get
            {
                return mMType;
            }
            set
            {
                mMType = value;
            }
        }

        public string AType
        {
            get
            {
                return mAType;
            }
            set
            {
                mAType = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public int Accuracy
        {
            get
            {
                return mAccuracy;
            }
        }
        public int Poison
        {
            get
            {
                return mPoisonP;
            }
        }
    }
}
