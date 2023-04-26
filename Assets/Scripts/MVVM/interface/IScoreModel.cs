using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVVM.Model
{
    public interface IScoreModel
    {
        public float BeginScore { get; }
        public float CurrentScore { get; set; }

    }
}