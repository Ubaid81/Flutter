import 'package:flutter/material.dart';

void main() => runApp(MaterialApp(home: Home()));

class Home extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        child: Column(children: <Widget>[
          SizedBox(height: 100.0),
          Container(
            height: 100.0,
            child: Center(
              child: Image(
                alignment: Alignment.center,
                image: AssetImage('assets/img1.png'),
                color: Color.fromRGBO(25, 214, 210, 10),
              ),
            ),
          ),
          SizedBox(height: 40.0),
          Container(
            height: 50.0,
            width: 300.0,
            child: TextFormField(
              keyboardType: TextInputType.name,
              decoration: InputDecoration(
                  prefixIcon: Icon(
                    Icons.person,
                  ),
                  labelText: 'Username'),
            ),
            color: Colors.white,
          ),
          SizedBox(height: 15.0),
          Container(
            height: 50.0,
            width: 300.0,
            child: TextFormField(
              keyboardType: TextInputType.text,
              decoration: InputDecoration(
                  prefixIcon: Icon(
                    Icons.lock,
                  ),
                  labelText: 'Password'),
              obscureText: true,
            ),
            color: Colors.white,
          ),
          SizedBox(height: 15.0),
          Container(
            height: 50.0,
            width: 300.0,
            child: ElevatedButton(
              onPressed: () {},
              child: Center(
                child: Text(
                  'Sign In',
                ),
              ),
            ),
          ),
        ]),
        color: Color.fromRGBO(171, 241, 217, 20),
      ),
    );
  }
}
