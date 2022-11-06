using System.Collections.Generic;
using System.IO;
using System;

namespace Unit04.Game.Casting
{
        public class Artifact:Actor{
            private int score = 0;

        


  
            public Artifact(){

            }
       

            public int GetScore(){
                
                return score;

            }
        
            public void SetScore(int score){
                this.score = score;

            }
        }
}