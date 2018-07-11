const express = require('express');
const router= express.Router();
const mysql = require('mysql');
const db = require('../db/dbConnector');

router.post('/', (req, res) => {
    console.log('insert into sessao(dataSessao,tempoPassado,idNivel,idSessaoContra,personagem,idUtilizador)values("'+
    req.body.date+'",'+parseFloat(req.body.elapsedTime)+','+parseInt(req.body.level)+','+parseInt(req.body.opponentSession)+
    ',"'+req.body.character+'",'+parseInt(req.body.userID)+')');
    let sql='insert into sessao(dataSessao,tempoPassado,idNivel,idSessaoContra,personagem,idUtilizador) values("'+
    req.body.date+'",'+parseFloat(req.body.elapsedTime)+','+parseInt(req.body.level)+','+parseInt(req.body.opponentSession)+
    ',"'+req.body.character+'",'+parseInt(req.body.userID)+')';
    let query = db.query(sql, (err, result) => {
        if(err) throw res.json({success: false, message: err});;
        res.json({success: true, message: result["insertId"]});
    });
});

router.get('/:id', (req, res) => {
    let sql=`SELECT * FROM sessao where idSessao=${req.params.id}`;
    let query = db.query(sql, (err, result) => {
        if(err) throw res.json({success: false, message: "session nto found"});;
        //res.send(result);
        res.json({success: true, content: result});
    });
});

router.get('/levels/:id', (req, res) => {
    let sql=`SELECT * FROM nivel where idNivel in (select distinct(idNivel) from sessao where idUtilizador=${req.params.id})`;
    let query = db.query(sql, (err, result) => {
        if(err) throw res.json({success: false, message: "session nto found"});;
        //res.send(result);
        res.json({success: true, content: result});
    });
});

module.exports=router;