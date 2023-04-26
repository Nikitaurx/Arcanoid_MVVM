using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MVVM.Model;

namespace MVVM.ViewModel
{
    public interface IViewModel
    {
        IScoreModel ScoreModel { get; }
        void ScoreProgress(float score);
        event Action<float> OnScoreChange;
    }
}
