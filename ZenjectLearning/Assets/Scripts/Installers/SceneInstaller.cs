//using UnityEngine;
//using Zenject;

//public sealed class SceneInstaller : MonoInstaller
//{
//    [SerializeField] private Vector3 _cameraOffset = new (0, 6, -10);

//    public override void InstallBindings()
//    {
//        this.Container
//            .Bind<ICharacter>()
//            .To<Character>()
//            .FromComponentInHierarchy()
//            .AsSingle();

//        this.Container
//            .Bind<Camera>()
//            .FromComponentInHierarchy()
//            .AsSingle();

//        this.Container
//            .BindInterfacesAndSelfTo<CameraFollower>()
//            .AsCached()
//            .WithArguments(this._cameraOffset);
//    }
//}
