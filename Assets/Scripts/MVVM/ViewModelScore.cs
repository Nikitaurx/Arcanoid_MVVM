using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using MVVM.Model;

namespace MVVM.ViewModel
{
    public class ViewModelScore : IViewModel
    {
        public IScoreModel ScoreModel { get; }
        public event Action<float> OnScoreChange;

        public ViewModelScore(IScoreModel scoreModel)
        {
            ScoreModel = scoreModel;
        }

        public void ScoreProgress(float score)
        {
            ScoreModel.CurrentScore += score;
            if (ScoreModel.CurrentScore > 2550f)
            {
                Debug.Log("You win!");
            }
            OnScoreChange?.Invoke(ScoreModel.CurrentScore);
        }
    }
}
