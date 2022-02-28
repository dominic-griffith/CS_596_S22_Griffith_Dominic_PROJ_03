using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FlockingBehavior))]                        //Need to tell the Editor what class to act on
[CanEditMultipleObjects]

public class FlockingBehaviorEditor : Editor
{

     
    bool showLazy = false;
    bool showCircleTree = false;
    bool showFollowLeader = false;
     

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        FlockingBehavior flock = (FlockingBehavior)target;               // Target is the thing the editor is working on

        showLazy = EditorGUILayout.Foldout(showLazy, "Lazy Flock");

        if (showLazy)
        {
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            GUILayout.Label("Random flight paths points", EditorStyles.boldLabel);
            if (GUILayout.Button("Lazy Flock"))
            {
                flock.LazyFlight();                      //Do the thing in yourr other class
            }
        }

        showCircleTree = EditorGUILayout.Foldout(showCircleTree, "Circle Tree");

        if (showCircleTree)
        {
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            GUILayout.Label("Specified geometric path", EditorStyles.boldLabel);
            if (GUILayout.Button("Circle Tree"))
            {
                flock.CircleTree();                      //Do the thing in yourr other class
            }
        }

        showFollowLeader = EditorGUILayout.Foldout(showFollowLeader, "Follow the Leader");

        if (showFollowLeader)
        {
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            GUILayout.Label("User controlled character", EditorStyles.boldLabel);
            GUILayout.Label("Controls: WSAD, shift for down, space for up");
            if (GUILayout.Button("Follow the Leader"))
            {
                flock.FollowLeader();                      //Do the thing in yourr other class
            }
        }


        serializedObject.ApplyModifiedProperties();
    }
}