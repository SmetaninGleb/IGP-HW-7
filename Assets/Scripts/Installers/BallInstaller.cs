using UnityEditor;
using UnityEngine;
using Zenject;

public class BallInstaller : MonoInstaller
{
    [SerializeField] private int _initialHealth = 10;
    [SerializeField] private BallView _ballView;
    public override void InstallBindings()
    {
        Container.Bind<BallModel>()
            .FromNew()
            .AsCached()
            .WithArguments(_initialHealth)
            .NonLazy();
        Container.Bind<BallView>()
            .FromInstance(_ballView);
        Container.Bind<BallPresenter>()
            .FromNew()
            .AsCached()
            .NonLazy();
    }
}