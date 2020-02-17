using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BlurC : MonoBehaviour{
    public Material EffectMaterial;

    [Range(0, 10)]
    public int BlurIterations;
    [Range(0, 4)]
    public int DownRes;

    //Camera camera;

    void OnRenderImage(RenderTexture source, RenderTexture destination){
        int width = source.width >> DownRes;
        int height = source.height >> DownRes;

        RenderTexture rt = RenderTexture.GetTemporary(width, height);
        Graphics.Blit(source, rt);
        for( int i = 0; i < BlurIterations; i++){
             RenderTexture rt2 = RenderTexture.GetTemporary(width, height);
             Graphics.Blit(rt, rt2, EffectMaterial);
            RenderTexture.ReleaseTemporary(rt);

            rt = rt2;
        }
        Graphics.Blit(rt, destination);
        RenderTexture.ReleaseTemporary(rt);
    }

}
