using UnityEngine;
using Zenject;

public class ExitController : ITickable
{
    private readonly ApplicationFinisher _applicationFinisher;

    public ExitController(ApplicationFinisher applicationFinisher)
    {
        _applicationFinisher = applicationFinisher;
    }
    void ITickable.Tick()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            _applicationFinisher.Finish();
        }
    }
}
