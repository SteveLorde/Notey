import 'package:flutter/material.dart';
import 'package:notey/Components/NotesBar.dart';
import 'package:notey/Components/NoteCanvas.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: Home(),
    );
  }
}

class Home extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Row(
      children: [
        Column(
          children: [
            NotesBar()
          ],
        ),
        Column(
          children: [
            NoteCanvas()
          ],
        )
      ],
    );
  }
}


}
