using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVVM.Model;
using MVVM.View;
using MVVM.ViewModel;

namespace MVVM
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private ViewText _view;
        [SerializeField] private ViewSumScore _viewSumScore;
        private void Start()
        {
            var Model = new ScoreModel(0);
            var ViewModel = new ViewModelScore(Model);
            _view.Initialzie(ViewModel);
            _viewSumScore.Initialzie(ViewModel);
        }
    }
}

