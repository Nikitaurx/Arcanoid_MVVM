using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MVVM.ViewModel;

namespace MVVM.View
{
    public class ViewText : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private IViewModel _viewModel;

        public void Initialzie(IViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.OnScoreChange += OnScoreChange;
            OnScoreChange(_viewModel.ScoreModel.CurrentScore);
        }
        private void OnScoreChange(float currentScore)
        {
            _text.text = currentScore.ToString();
        }
        ~ViewText()
        {
            _viewModel.OnScoreChange -= OnScoreChange;
        }
    }
}

