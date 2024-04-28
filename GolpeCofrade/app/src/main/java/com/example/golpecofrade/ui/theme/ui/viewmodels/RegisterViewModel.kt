package com.example.golpecofrade.ui.theme.ui.viewmodels

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import kotlinx.coroutines.delay

class RegisterViewModel: ViewModel(){

    private  val _username = MutableLiveData<String>()
    val username : LiveData<String> = _username

    private  val _password = MutableLiveData<String>()
    val password : LiveData<String> = _password

    private  val _buttonEnabled = MutableLiveData<Boolean>()
    val buttonEnabled : LiveData<Boolean> = _buttonEnabled

    private  val _isloading = MutableLiveData<Boolean>()
    val isloading : LiveData<Boolean> = _isloading

    fun onLoginChanged(username:String, password: String){
        _username.value = username
        _password.value = password
        _buttonEnabled.value = isValidUsername(username) && isValidPassword(password)
    }

    /**
     * Funcion que comprueba que el username solo contiene letras, numeros y guiones bajos
     * Ademas tambien comprueba la longitud del username
     */
    private fun isValidUsername(username: String): Boolean {
        val pattern = Regex("^[a-zA-Z0-9_]*\$")

        return pattern.matches(username) && username.length > 1
    }

    /**
     * Funcion que comprueba que la longitud de la longitud de la contrasena sea mayor a 8 y menor
     */
    private fun isValidPassword(password: String): Boolean = password.length > 8 && password.length < 20

    suspend fun onLoginSelected() {
        _isloading.value=true
        delay(4000)
        _isloading.value=false
    }


}