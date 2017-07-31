﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightModel : MonoBehaviour{

    Material material;

    private Vector4 _diffuse;
    private Vector4 _specular;

    void Awake()
    {
        material = gameObject.GetComponent<MeshRenderer>().sharedMaterial;
        _diffuse = Vector4.one;
        _specular = Vector4.one;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 10);
    }

	public void IsVertexDiffuse(bool check)
    {
        if (check)
            material.SetFloat("_vertex_diffuse", 1.0f);
        else
            material.SetFloat("_vertex_diffuse", 0.0f);
    }

    public void IsFragmentDiffuse(bool check)
    {
        if (check)
            material.SetFloat("_fragment_diffuse", 1.0f);
        else
            material.SetFloat("_fragment_diffuse", 0.0f);
    }

    public void IsLambert(bool check)
    {
        if (check)
            material.SetFloat("_Lambert", 1.0f);
        else
            material.SetFloat("_Lambert", 0.0f);
    }

    public void IsVertexSpecular(bool check)
    {
        if (check)
            material.SetFloat("_vertex_specular", 1.0f);
        else
            material.SetFloat("_vertex_specular", 0.0f);
    }

    public void IsFragmentSpecular(bool check)
    {
        if (check)
            material.SetFloat("_fragment_specular", 1.0f);
        else
            material.SetFloat("_fragment_specular", 0.0f);
    }

    public void IsPhong(bool check)
    {
        if (check)
            material.SetFloat("_Phong", 1.0f);
        else
            material.SetFloat("_Phong", 0.0f);
    }

    public void ChangeDiffuseR(float value)
    {
        _diffuse.x = value;
        material.SetColor("_Diffuse", _diffuse);
    }

    public void ChangeDiffuseG(float value)
    {
        _diffuse.y = value;
        material.SetColor("_Diffuse", _diffuse);
    }

    public void ChangeDiffuseB(float value)
    {
        _diffuse.z = value;
        material.SetColor("_Diffuse", _diffuse);
    }

    public void ChangeSpecularR(float value)
    {
        _specular.x = value;
        material.SetColor("_Specular", _specular);
    }

    public void ChangeSpecularG(float value)
    {
        _specular.y = value;
        material.SetColor("_Specular", _specular);
    }

    public void ChangeSpecularB(float value)
    {
        _specular.z = value;
        material.SetColor("_Specular", _specular);
    }

    public void ChangeGloss(float value)
    {
        material.SetFloat("_Gloss", value * 100);
    }
}