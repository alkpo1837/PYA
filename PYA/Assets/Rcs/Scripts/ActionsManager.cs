using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsManager : MonoBehaviour
{
    [Header("References")]
    public Player PlayerI;

    private static ActionsManager _instance = null;
    public static ActionsManager Instance { get { return _instance; } }

    private int _currentIndexAction = 0;
    private List<IAction> _actions;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }

        _actions = new List<IAction>();
    }

    public void Add(IAction action)
    {
        _actions.Add(action);
    }

    public void Remove(IAction action)
    {
        _actions.Remove(action);
    }

    public void Play()
    {
        Debug.Log("Lets play");
        _currentIndexAction = 0;

        foreach (IAction action in _actions)
            action.OnFinished += playNextAction;
        
        _actions[_currentIndexAction].Play(PlayerI);
    }

    private void playNextAction()
    {
        _currentIndexAction++;

        if (_currentIndexAction < _actions.Count)
        {
            _actions[_currentIndexAction].Play(PlayerI);
            _actions[_currentIndexAction].OnFinished += playNextAction;
        }
        else
        {
            finishSequence();
        }
    }

    private void finishSequence()
    {
        foreach (IAction action in _actions)
            action.OnFinished -= playNextAction;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            // Create Move
            GameObject go = new GameObject(string.Format("{0}_Move", _actions.Count));
            ActionMove a = go.AddComponent<ActionMove>();

            a.Direction = Vector3.right;
            a.Speed = 500.0f;
            a.Duration = 1.0f;

            Add(a);

            go.transform.SetParent(transform);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            GameObject go = new GameObject(string.Format("{0}_Wait", _actions.Count));
            ActionWait w = go.AddComponent<ActionWait>();

            w.Duration = 1.0f;

            Add(w);

            go.transform.SetParent(transform);
        }
    }

}
