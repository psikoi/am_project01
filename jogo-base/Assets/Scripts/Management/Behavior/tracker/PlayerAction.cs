using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction {

    public ActionType type;
    public int startTick;
    public int endTick;
    public bool executed;

    public PlayerAction(ActionType type, int startTick, int endTick) {
        this.type = type;
        this.startTick = startTick;
        this.endTick = endTick;
        executed = false;
    }

}
