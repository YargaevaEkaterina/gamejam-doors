using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleClick : MonoBehaviour
{
    public ParticleSystem particles; // ���������� ���� ������� ������ � ��� ���� ����� �������� Unity

    void Start()
    {
        particles.Stop(); // ���������, ��� ������� ����������� ��� ������� �����
    }

    public void ActivateParticles()
    {
        particles.Play(); // ��������� ������� ������
        // �������������� ��������, ���� ���������
    }
}
