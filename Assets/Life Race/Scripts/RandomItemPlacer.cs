﻿using UnityEngine;
using System.Collections;

public class RandomItemPlacer : PipeItemGenerator
{
    public PipeItem[] itemPrefabs;

    public override void GenerateItem(Pipe pipe)
    {
        float angleStep = pipe.CurveAngle / pipe.CurveSegment;

        for (int i = 0; i < pipe.CurveSegment; i +=4 )
        {
            PipeItem item = Instantiate(itemPrefabs[Random.Range(0, itemPrefabs.Length)]);

            float pipeRotation = (Random.Range(0, pipe.pipeSegment) + 0.5f) * (360f / pipe.pipeSegment);

            item.Position(pipe, i * angleStep, new Vector3(0f, pipeRotation, pipeRotation));
        }
    }
}
