package com.example.golpecofrade

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import com.example.golpecofrade.ui.theme.GolpeCofradeTheme
import com.example.golpecofrade.ui.theme.ui.navigation.AppNavigation
import com.example.golpecofrade.ui.theme.ui.screens.LoginScreen
import com.example.golpecofrade.ui.theme.ui.screens.RegisterScreen2
import com.example.golpecofrade.ui.theme.ui.viewmodels.LoginViewModel

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            GolpeCofradeTheme {
                AppNavigation()
            }
        }
    }
}

@Composable
fun Greeting(name: String, modifier: Modifier = Modifier) {
    Text(
            text = "Hello $name!",
            modifier = modifier
    )
}

@Preview(showBackground = true)
@Composable
fun GreetingPreview() {
    GolpeCofradeTheme {
        Greeting("Android")
    }
}