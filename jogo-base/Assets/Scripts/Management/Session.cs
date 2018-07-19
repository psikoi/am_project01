using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Session
{
    public int id;
    public DateTime date;
    public float elapsedTime;
    public User user;
    public Character character;
    public Session opponentSession;
    public List<PlayerAction> actions;
    public int level;

    public Session(int id, User user, Character character, Session opponentSession, int level) :
        this(id, user, character, opponentSession, new List<PlayerAction>(), level){ }
    

    public Session(int id, User user, Character character, Session opponentSession, List<PlayerAction> actions, int level)
    {
        this.id = id;
        date = DateTime.Now;
        this.actions = actions;
        elapsedTime = 0;
        this.user = user;
        this.character = character;
        this.opponentSession = opponentSession;
        this.level = level;
    }

    public Session(int id, User user, Character character, Session opponentSession, List<PlayerAction> actions, int level,float elapsedTime)
    {
        this.id = id;
        date = DateTime.Now;
        this.actions = actions;
        this.elapsedTime = elapsedTime;
        this.user = user;
        this.character = character;
        this.opponentSession = opponentSession;
        this.level = level;
    }
}
