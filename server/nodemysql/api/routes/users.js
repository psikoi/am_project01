const express = require('express');
const router= express.Router();
const mysql = require('mysql');
const db = require('../db/dbConnector');
  
router.get('/', (req, res) => {
    let sql='SELECT * FROM Utilizador';
    let query = db.query(sql, (err, result) => {
        if(err) throw res.json({success: false, message: err});;
        console.log(result[0].idUtilizador);
        res.json({success: true, message: result});
    });
});

router.get('/:id', (req, res) => {
    let sql=`SELECT * FROM Utilizador where idUtilizador=${req.params.id}`;
    let query = db.query(sql, (err, result) => {
        if(err) throw res.json({success: false, message: "user not found"});;
        console.log(result[0].idUtilizador);
        res.json({success: true, message: result});
    });
});

router.post('/', (req, res) => {
    let sql=mysql.format('SELECT * FROM Utilizador where username=? and pw=?',[req.body.username,req.body.password]);
    let query = db.query(sql, (err, result) => {
    if(err) throw res.json({success: false, message: err});;
    console.log(result[0])
       if(result[0]){
            res.json({success: true, message: result});
       }else{
            res.json({success: false, message: "Credenciais incorretas!"});
       }   
    });
});

module.exports=router;