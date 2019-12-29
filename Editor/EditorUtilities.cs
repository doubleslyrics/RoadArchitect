﻿using UnityEngine;


namespace RoadArchitect
{
    public class EditorUtilities
    {


        /// <summary> Opens the loacally stored manual </summary>
        public static void OpenOfflineManual()
        {
            Application.OpenURL(System.Environment.CurrentDirectory.Replace(@"\", "/") + "/" + GSDRoadUtilityEditor.GetBasePath() + "/RoadArchitectManual.htm");
        }


        /// <summary> Loads the _texture from _path if necessary </summary>
        public static void CheckLoadTexture<T>(ref T _texture, string _path) where T : Texture
        {
            if (_texture == null)
            {
                _texture = (T)UnityEditor.AssetDatabase.LoadAssetAtPath(_path, typeof(T)) as T;
            }
        }


        public static void DrawLine(float _spacing = 4f, float _size = 1f)
        {
            //Horizontal bar
            GUILayout.Space(_spacing);
            GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(_size));
            GUILayout.Space(_spacing);
        }
    }
}