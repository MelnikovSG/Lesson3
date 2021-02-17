using UnityEngine;
using UnityEngine.UI;

namespace RollBall
{
	public sealed class RadarObj : Radar

	{
		[SerializeField] private Image _ico;

        private void OnValidate()
        {
            _ico = Resources.Load<Image>("MiniMap/RadarObject");
        }

        private void OnDisable()
		{
			Radar.RemoveRadarObject(gameObject);
		}

		private void OnEnable()
		{
			Radar.RegisterRadarObject(gameObject, _ico);
		}
	}
}