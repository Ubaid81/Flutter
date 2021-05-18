import 'package:flutter/material.dart';

void main() => runApp(MaterialApp(home: Home()));

class Home extends StatelessWidget {
  final _formKey = GlobalKey<FormState>();
  final _passwordController = TextEditingController();
  final _confirmPasswordController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SingleChildScrollView(
            child: Container(
      padding: EdgeInsets.symmetric(
        vertical: 1.0,
        horizontal: 1.0,
      ),
      child: _buildform(),
    )));
  }

  Form _buildform() {
    return Form(
      key: _formKey,
      child: Column(children: <Widget>[
        SizedBox(height: 100.0),
        Container(
          height: 100.0,
          child: Center(
            child: Image(
              alignment: Alignment.center,
              image: AssetImage('assets/successive_logo.png'),
            ),
          ),
        ),
        SizedBox(height: 20.0),
        Container(
          height: 50.0,
          width: 300.0,
          child: TextFormField(
            keyboardType: TextInputType.name,
            decoration: InputDecoration(
                border: OutlineInputBorder(
                  borderRadius: BorderRadius.circular(25.0),
                  borderSide: BorderSide(color: Colors.grey, width: 5.0),
                ),
                prefixIcon: Icon(
                  Icons.person,
                ),
                labelText: 'Full Name'),
            validator: (value) => value.isEmpty
                ? '* Required'
                : RegExp(r'[!@#<>?":_`~;[\]\\|=+)(*&^%0-9-]').hasMatch(value)
                    ? 'Enter a Valid Name'
                    : null,
          ),
        ),
        SizedBox(height: 10.0),
        Container(
          height: 50.0,
          width: 300.0,
          child: TextFormField(
              keyboardType: TextInputType.emailAddress,
              decoration: InputDecoration(
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide: BorderSide(color: Colors.grey, width: 5.0),
                  ),
                  prefixIcon: Icon(
                    Icons.email,
                  ),
                  labelText: 'Email'),
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return '* Required';
                }

                const pattern = r'^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$';
                final regExp = RegExp(pattern);

                if (!regExp.hasMatch(value)) {
                  return 'Enter Valid Email Id';
                } else {
                  return null;
                }
              }),
        ),
        SizedBox(height: 10.0),
        Container(
          height: 50.0,
          width: 300.0,
          child: TextFormField(
              keyboardType: TextInputType.phone,
              decoration: InputDecoration(
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide: BorderSide(color: Colors.grey, width: 5.0),
                  ),
                  prefixIcon: Icon(
                    Icons.phone,
                  ),
                  labelText: 'Phone Number'),
              validator: (value) {
                if (value.length != 10)
                  return 'Mobile Number must be of 10 digit';
                else
                  return null;
              }),
        ),
        SizedBox(height: 10.0),
        Container(
          height: 50.0,
          width: 300.0,
          child: TextFormField(
            keyboardType: TextInputType.text,
            decoration: InputDecoration(
                border: OutlineInputBorder(
                  borderRadius: BorderRadius.circular(25.0),
                  borderSide: BorderSide(color: Colors.grey, width: 5.0),
                ),
                prefixIcon: Icon(
                  Icons.lock,
                ),
                labelText: 'Create Password'),
            obscureText: true,
            controller: _passwordController,
            validator: (value) {
              if (value.isEmpty) {
                return "* Required";
              } else if (value.length < 6) {
                return "Password should be atleast 6 characters";
              } else if (value.length > 10) {
                return "Password should not be greater than 10 characters";
              } else
                return null;
            },
          ),
        ),
        SizedBox(height: 10.0),
        Container(
          height: 50.0,
          width: 300.0,
          child: TextFormField(
            keyboardType: TextInputType.text,
            decoration: InputDecoration(
                border: OutlineInputBorder(
                  borderRadius: BorderRadius.circular(25),
                  borderSide: BorderSide(color: Colors.grey, width: 5.0),
                ),
                prefixIcon: Icon(
                  Icons.lock,
                ),
                labelText: 'Confirm Password'),
            obscureText: true,
            controller: _confirmPasswordController,
            validator: (String value) {
              if (value != _passwordController.value.text) {
                return 'Passwords do not match!';
              }
              return null;
            },
          ),
        ),
        SizedBox(height: 10.0),
        Container(
          height: 50.0,
          width: 300.0,
          child: Material(
            borderRadius: BorderRadius.circular(25.0),
            color: Colors.lightBlueAccent,
            child: ElevatedButton(
              onPressed: () {
                if (_formKey.currentState.validate()) {
                  debugPrint('All validations passed!!!');
                }
              },
              style: ButtonStyle(
                shape: MaterialStateProperty.all<RoundedRectangleBorder>(
                  RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(25.0),
                  ),
                ),
              ),
              child: Center(
                child: Text(
                  'Sign Up',
                ),
              ),
            ),
          ),
        ),
        Container(
          height: 100.0,
          child: Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: <Widget>[
                Text(
                  'Already have an account ?',
                ),
                SizedBox(width: 5.0),
                InkWell(
                  onTap: () {},
                  child: Text(
                    'Sign In',
                    style: TextStyle(color: Colors.blue),
                  ),
                ),
              ]),
        ),
      ]),
    );
  }
}
