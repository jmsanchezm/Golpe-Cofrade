package com.example.golpecofrade.ui.theme.entites

import androidx.lifecycle.LiveData

class User {

    private var _id: Int = 0
    private var _usuario : String = ""
    private var _contraseña : String = ""
    private var _email : String = ""
    private var _nombre:String = ""
    private var _apellidos:String = ""
    private var _numTelefono :String = ""
    private var _numTarjetaBancaria : String =""
    private var _cvv:Int = 0

    // Constructor sin parámetros
    constructor()

    // Constructor con parámetros
    constructor(id: Int, usuario: String, contraseña: String, email: String, nombre: String, apellidos: String, numTelefono: String, numTarjetaBancaria: String, cvv: Int) {
        this._id = id
        this._usuario = usuario
        this._contraseña = contraseña
        this._email = email
        this._nombre = nombre
        this._apellidos = apellidos
        this._numTelefono = numTelefono
        this._numTarjetaBancaria = numTarjetaBancaria
        this._cvv = cvv
    }


    var id : Int = _id
    var usuario: String = _usuario
    var contraseña: String = _contraseña
    var email: String = _email
    var nombre: String = _nombre
    var apellidos: String = _apellidos
    var numTelefono: String = _numTelefono
    var numTarjetaBancaria: String = _numTarjetaBancaria
    var cvv: Int = _cvv

}