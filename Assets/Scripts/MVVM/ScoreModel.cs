using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVVM.Model
{
    public class ScoreModel : IScoreModel
    {
        public float BeginScore { get; }
        public float CurrentScore { get; set; }
        public ScoreModel(float beginScore)
        {
            BeginScore = beginScore;
            CurrentScore = BeginScore;
        }
    }
}

