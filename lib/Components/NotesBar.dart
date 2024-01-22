import 'package:flutter/material.dart';

class NotesBar extends StatelessWidget {
  const NotesBar({super.key});

  @override
  Widget build(BuildContext context) {
    return Container(
      child: SavedNotes(),
    );
  }
}

class SavedNotes extends StatefulWidget {
  const SavedNotes({super.key});

  @override
  State<SavedNotes> createState() => _SavedNotesState();
}

class _SavedNotesState extends State<SavedNotes> {
  @override
  Widget build(BuildContext context) {
    return const Placeholder();
  }
}


