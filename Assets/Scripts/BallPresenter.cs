using System;
using System.Collections;
using UnityEngine;

public class BallPresenter : IDisposable
{
    private readonly BallModel _ballModel;
    private readonly BallView _ballView;

    public BallPresenter (BallView ballView, BallModel ballModel)
    {
        _ballModel = ballModel;
        _ballView = ballView;
        _ballModel.HealthChanged += OnHealthChanged;
        _ballView.CollidedWithBox += OnCollidedWithBox;
    }

    public void Dispose()
    {
        _ballModel.HealthChanged -= OnHealthChanged;
        _ballView.CollidedWithBox -= OnCollidedWithBox;
    }

    private void OnCollidedWithBox()
    {
        _ballModel.OnCollidedWithBox();
    }

    private void OnHealthChanged()
    {
        _ballView.DispsayHealth(_ballModel.Health);
    }
}