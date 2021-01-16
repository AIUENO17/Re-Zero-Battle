using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterParamManager : MonoBehaviour
{
    public CharacterParam CharacterParam = new CharacterParam();

    public CharacterParam GetCharacterParam
    {
        get { return CharacterParam; }
    }


    public int CharacterHP = 0;
    public int CharacterMp = 0;
    public float CharacterSpeed = 0;
    public CharacterParam.GameCharacterType CharacterType = CharacterParam.GameCharacterType.Invalide;
    // Start is called before the first frame update
   private  void Init()
    {
        CharacterParam.HitPoint = CharacterHP;
    
       CharacterParam.MagicPoint = CharacterMp;

        CharacterParam.Speed = CharacterSpeed;

        CharacterParam.CharacterType = CharacterType;
    }

    // Update is called once per frame
   private  void Awake()
    {
        Init();
    }
}
