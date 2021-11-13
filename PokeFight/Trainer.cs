using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeFight
{
    class Trainer
    {
        public Monster[] mParty;
        private string mName;
        public int mHealth;

        public Trainer(string name, int pSize)
        {
            mName = name;
            mParty = new Monster[pSize];
        }
        //switch around team
        public void rotate(int location)
        {
            Monster placeHolder = mParty[0];
            mParty[0] = mParty[location];
            mParty[location] = placeHolder;
        }

        //initialize pokemon Party
        public void setParty(Monster poke, int place)
        {
            mParty[place] = poke;
        }

        //display team when enstating team
        public string disParty(int p)
        {
            string output = "_________________________________________________________________\n|\t\t\t\t\t\t\t\t|\n";
            for (int x = 0; x <= p; x++)
            {
                if(mParty[x].getName().Length>7)
                    output += $"|\t{x+1}:\t{mParty[x].getName()}\t\tHP: {mParty[x].dispHP()}\tlvl: {mParty[x].getLvl()}\t|\n|\t\t\t\t\t\t\t\t|\n";
                else
                    output += $"|\t{x + 1}:\t{mParty[x].getName()}\t\t\tHP: {mParty[x].dispHP()}\tlvl: {mParty[x].getLvl()}\t|\n|\t\t\t\t\t\t\t\t|\n";
            }
            output += "_________________________________________________________________";
            return output;
        }
        //display team after it has been made
        public string disParty()
        {
            string output = "_________________________________________________________________\n|\t\t\t\t\t\t\t\t|\n";
            for (int x = 0; x < mParty.Length; x++)
            {
                if (mParty[x].getName().Length > 7)
                    output += $"|\t{x + 1}:\t{mParty[x].getName()}\t\tHP: {mParty[x].dispHP()}\tlvl: {mParty[x].getLvl()}\t|\n|\t\t\t\t\t\t\t\t|\n";
                else
                    output += $"|\t{x + 1}:\t{mParty[x].getName()}\t\t\tHP: {mParty[x].dispHP()}\tlvl: {mParty[x].getLvl()}\t|\n|\t\t\t\t\t\t\t\t|\n";
            }
            output += "_________________________________________________________________";
            return output;
        }

        public string getName()
        {
            return mName;
        }

        public Monster getMember(int x)
        {
            return mParty[x];
        }

        public Attack CPUAttack(Trainer mother)
        {
            Random rng = new Random();
            Monster other = mother.getMember(0);
            Attack atk = this.getMember(0).getMove(0); 
            int smart = rng.Next(1, 4);
            double effective = 1;
            double maxEffective = double.MinValue;
            int moveNum=rng.Next(0,4);
            if(smart==1 || smart==2)
            {
                for(int x = 0; x<4; x++)
                {
                    effective = 1;
                    if (((other.getType().Contains("grass") || other.getType().Contains("ice") || other.getType().Contains("bug") || other.getType().Contains("steel")) && atk.MType.Equals("fire"))/*fire*/ || ((other.getType().Contains("fire") || other.getType().Contains("ground") || other.getType().Contains("rock")) && atk.MType.Equals("water"))/*water*/ || ((other.getType().Contains("water") || other.getType().Contains("flying")) && atk.MType.Equals("electric"))/*electric*/  || ((other.getType().Contains("water") || other.getType().Contains("ground") || other.getType().Contains("rock")) && atk.MType.Equals("grass"))/*grass*/ || ((other.getType().Contains("grass") || other.getType().Contains("ground") || other.getType().Contains("flying") || other.getType().Contains("dragon")) && atk.MType.Equals("ice"))/*ice*/ || ((other.getType().Contains("normal") || other.getType().Contains("ice") || other.getType().Contains("rock") || other.getType().Contains("dark") || other.getType().Contains("steel")) && atk.MType.Equals("fighting"))/*fighting*/ || ((other.getType().Contains("grass") || other.getType().Contains("fairy")) && atk.MType.Equals("poison"))/*poison*/ || ((other.getType().Contains("fire") || other.getType().Contains("electric") || other.getType().Contains("poison") || other.getType().Contains("rock") || other.getType().Contains("steel")) && atk.MType.Equals("ground"))/*ground*/ || ((other.getType().Contains("grass") || other.getType().Contains("bug") || other.getType().Contains("fighting")) && atk.MType.Equals("flying"))/*flying*/ || ((other.getType().Contains("poison") || other.getType().Contains("fighting")) && atk.MType.Equals("psychic"))/*psychic*/ || ((other.getType().Contains("grass") || other.getType().Contains("psychic") || other.getType().Contains("dark")) && atk.MType.Equals("bug"))/*bug*/ || ((other.getType().Contains("fire") || other.getType().Contains("ice") || other.getType().Contains("flying") || other.getType().Contains("bug")) && atk.MType.Equals("rock"))/*rock*/ || ((other.getType().Contains("psychic") || other.getType().Contains("ghost")) && atk.MType.Equals("ghost"))/*ghost*/ || ((other.getType().Contains("dragon")) && atk.MType.Equals("dragon"))/*dragon*/ || ((other.getType().Contains("psychic") || other.getType().Contains("ghost")) && atk.MType.Equals("dark"))/*dark*/ || ((other.getType().Contains("ice") || other.getType().Contains("rock") || other.getType().Contains("fairy")) && atk.MType.Equals("steel"))/*steel*/ || ((other.getType().Contains("dragon") || other.getType().Contains("dark") || other.getType().Contains("fighting")) && atk.MType.Equals("fairy"))/*fairy*/)
                        effective *= 2;
                    //checks type combo
                    if (other.getType().Contains("/") && (((other.getType().Contains("grass") || other.getType().Contains("ice") || other.getType().Contains("bug") || other.getType().Contains("steel")) && atk.MType.Equals("fire"))/*fire*/ || ((other.getType().Contains("fire") || other.getType().Contains("ground") || other.getType().Contains("rock")) && atk.MType.Equals("water"))/*water*/ || ((other.getType().Contains("water") || other.getType().Contains("flying")) && atk.MType.Equals("electric"))/*electric*/  || ((other.getType().Contains("water") || other.getType().Contains("ground") || other.getType().Contains("rock")) && atk.MType.Equals("grass"))/*grass*/ || ((other.getType().Contains("grass") || other.getType().Contains("ground") || other.getType().Contains("flying") || other.getType().Contains("dragon")) && atk.MType.Equals("ice"))/*ice*/ || ((other.getType().Contains("normal") || other.getType().Contains("ice") || other.getType().Contains("rock") || other.getType().Contains("dark") || other.getType().Contains("steel")) && atk.MType.Equals("fighting"))/*fighting*/ || ((other.getType().Contains("grass") || other.getType().Contains("fairy")) && atk.MType.Equals("poison"))/*poison*/ || ((other.getType().Contains("fire") || other.getType().Contains("electric") || other.getType().Contains("poison") || other.getType().Contains("rock") || other.getType().Contains("steel")) && atk.MType.Equals("ground"))/*ground*/ || ((other.getType().Contains("grass") || other.getType().Contains("bug") || other.getType().Contains("fighting")) && atk.MType.Equals("flying"))/*flying*/ || ((other.getType().Contains("poison") || other.getType().Contains("fighting")) && atk.MType.Equals("psychic"))/*psychic*/ || ((other.getType().Contains("grass") || other.getType().Contains("psychic") || other.getType().Contains("dark")) && atk.MType.Equals("bug"))/*bug*/ || ((other.getType().Contains("fire") || other.getType().Contains("ice") || other.getType().Contains("flying") || other.getType().Contains("bug")) && atk.MType.Equals("rock"))/*rock*/ || ((other.getType().Contains("psychic") || other.getType().Contains("ghost")) && atk.MType.Equals("ghost"))/*ghost*/ || ((other.getType().Contains("dragon")) && atk.MType.Equals("dragon"))/*dragon*/ || ((other.getType().Contains("psychic") || other.getType().Contains("ghost")) && atk.MType.Equals("dark"))/*dark*/ || ((other.getType().Contains("ice") || other.getType().Contains("rock") || other.getType().Contains("fairy")) && atk.MType.Equals("steel"))/*steel*/ || ((other.getType().Contains("dragon") || other.getType().Contains("dark") || other.getType().Contains("fighting")) && atk.MType.Equals("fairy"))/*fairy*/))
                        effective *= 2;
                    //not very effective multiplier
                    if (((other.getType().Contains("rock") || other.getType().Contains("steel")) && atk.MType.Equals("normal"))/*normal*/ || ((other.getType().Contains("fire") || other.getType().Contains("water") || other.getType().Contains("rock") || other.getType().Contains("dragon")) && atk.MType.Equals("fire"))/*fire*/ || ((other.getType().Contains("water") || other.getType().Contains("grass") || other.getType().Contains("dragon")) && atk.MType.Equals("water"))/*water*/ || ((other.getType().Contains("electric") || other.getType().Contains("grass") || other.getType().Contains("dragon")) && atk.MType.Equals("electric"))/*electric*/ || ((other.getType().Contains("fire") || other.getType().Contains("grass") || other.getType().Contains("poison") || other.getType().Contains("flying") || other.getType().Contains("bug") || other.getType().Contains("dragon") || other.getType().Contains("steel")) && atk.MType.Equals("grass"))/*grass*/ || ((other.getType().Contains("fire") || other.getType().Contains("water") || other.getType().Contains("ice") || other.getType().Contains("steel")) && atk.MType.Equals("ice"))/*ice*/ || ((other.getType().Contains("poison") || other.getType().Contains("flying") || other.getType().Contains("psychic") || other.getType().Contains("bug") || other.getType().Contains("fairy")) && atk.MType.Equals("fighting"))/*fighting*/ || ((other.getType().Contains("poison") || other.getType().Contains("ground") || other.getType().Contains("rock") || other.getType().Contains("ghost")) && atk.MType.Equals("poison"))/*poison*/ || ((other.getType().Contains("grass") || other.getType().Contains("bug")) && atk.MType.Equals("rock"))/*ground*/ || ((other.getType().Contains("electric") || other.getType().Contains("rock") || other.getType().Contains("steel")) && atk.MType.Equals("flying"))/*flying*/ || ((other.getType().Contains("psychic") || other.getType().Contains("steel")) && atk.MType.Equals("psychic"))/*psychic*/ || ((other.getType().Contains("fire") || other.getType().Contains("fighting") || other.getType().Contains("poison") || other.getType().Contains("flying") || other.getType().Contains("ghost") || other.getType().Contains("steel") || other.getType().Contains("fairy")) && atk.MType.Equals("bug"))/*bug*/ || ((other.getType().Contains("fighting") || other.getType().Contains("ground") || other.getType().Contains("steel")) && atk.MType.Equals("rock"))/*rock*/ || ((other.getType().Contains("dark")) && atk.MType.Equals("ghost"))/*ghost*/ || ((other.getType().Contains("steel")) && atk.MType.Equals("dragon"))/*dragon*/ || ((other.getType().Contains("fighting") || other.getType().Contains("dark") || other.getType().Contains("fairy")) && atk.MType.Equals("dark"))/*dark*/ || ((other.getType().Contains("fire") || other.getType().Contains("water") || other.getType().Contains("electric") || other.getType().Contains("steel")) && atk.MType.Equals("steel"))/*steel*/ || ((other.getType().Contains("fire") || other.getType().Contains("poison") || other.getType().Contains("steel")) && atk.MType.Equals("fairy"))/*fairy*/)
                        effective *= .5;
                    if ((other.getType().Contains("fairy") && atk.MType.Equals("dragon"))/*dragon*/ || (other.getType().Contains("normal") && atk.MType.Equals("ghost"))/*ghost*/ || (other.getType().Contains("dark") && atk.MType.Equals("psychic"))/*psychic*/ || (other.getType().Contains("flying") && atk.MType.Equals("ground"))/*ground*/ || (other.getType().Contains("ghost") && atk.MType.Equals("fighting"))/*fighting*/ || (other.getType().Contains("ground") && atk.MType.Equals("electric"))/*electric*/ || (other.getType().Contains("ghost") && atk.MType.Equals("normal"))/*normal*/)
                        effective *= 0;
                    if(effective>maxEffective && atk.PP>0 && atk.Name!= "Roost")
                    {
                        maxEffective = effective;
                        moveNum = x;
                    }
                    
                }
            }
            else
            {
                for (int x = 0; x < 4; x++)
                {
                    if(atk.Name == "Roost" && this.getMember(0).getHP() < this.getMember(0).getMHP() / 3)
                    {
                        moveNum = x;
                        break;
                    }
                    else
                        moveNum = rng.Next(0, 4);
                }
            }
            return this.getMember(0).getMove(moveNum);
        }

        public int Health
        {
            get
            {
                return mHealth;
            }
            set
            {
                mHealth = value;
            }
        }
    }
}
