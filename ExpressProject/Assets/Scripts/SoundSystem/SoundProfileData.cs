using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioActionType
{
    Attack,
    Button,
    BGM
}

[CreateAssetMenu(fileName = "Sound Profile", menuName = "Containers/SoundProfile", order = 1)]
public class SoundProfileData : ScriptableObject            //��ũ���ͺ� ������Ʈ�� ����
{
    [SerializeField] private AudioActionType audioType;             //����� Ÿ�� ����
    [SerializeField] private List<AudioClip> randomClipList;        //����Ʈ ������

    public AudioActionType AudioType => audioType;
    public List<AudioClip> RandomClipList => randomClipList;
    public AudioClip GetRandomClip() => RandomClipList.Count > 0 ? RandomClipList.RandomItem() : null;
    public AudioClip GetClipIndex(int index) => RandomClipList.Count > index ? RandomClipList[index] : null;

}
