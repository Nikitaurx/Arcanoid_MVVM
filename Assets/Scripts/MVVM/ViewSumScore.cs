using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MVVM.ViewModel;

namespace MVVM.View
{
    public class ViewSumScore : MonoBehaviour
    {
        [SerializeField] private float _score;
        //[SerializeField] private GameObject _block;
        private IViewModel _viewModel;

        public void Initialzie(IViewModel viewModel)
        {
            _viewModel = viewModel;

        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Block"))
            {
                _viewModel.ScoreProgress(_score);
                Destroy(other.gameObject);
            }
        }
    }
}
