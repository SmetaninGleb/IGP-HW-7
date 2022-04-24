using System.Collections;
using UnityEngine;
using Zenject;

public class Game : MonoBehaviour
{
    [Inject] private BallView _ballView;
    [Inject] private BallPresenter _ballPresenter;

    private void OnDestroy()
    {
        _ballPresenter.Dispose();
    }
}