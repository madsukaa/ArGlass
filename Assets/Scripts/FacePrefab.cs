using System.Linq;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
 
 
public class FacePrefab : MonoBehaviour {
    [SerializeField] new ParticleSystem particleSystem = null;
    [SerializeField] ARFace face = null;
    [SerializeField] int skipNumOfIndices = 1; // 1: top lip, 14: bottom lip, 78: left mouse corner, 292: right mouse corner
    [SerializeField] int visualizeNumOfIndices = 1;
 
 
    void Awake() {
        face.updated += delegate {
            var mainModule = particleSystem.main;
            var particles = face.vertices
                .Skip(skipNumOfIndices)
                .Take(visualizeNumOfIndices)
                .Select(pos => new ParticleSystem.Particle {
                    startColor = mainModule.startColor.color,
                    startSize = mainModule.startSize.constant,
                    position = pos,
                    remainingLifetime = 1
                })
                .ToArray();
             
            particleSystem.SetParticles(particles, particles.Length);
        };
    }
}
