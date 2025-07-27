// src/App.jsx
import { useEffect, useState } from 'react';

function App() {
    const [tasks, setTasks] = useState([]);

    useEffect(() => {
        fetch('http://localhost:5207/api/task') // измени URL на твой
            .then(res => res.json())
            .then(data => setTasks(data))
            .catch(err => console.error('Ошибка загрузки задач:', err));
    }, []);

    return (
        <div style={{ padding: 20 }}>
            <h1>Список задач</h1>
            {tasks.length === 0 && <p>Задач пока нет</p>}
            <ul>
                {tasks.map(task => (
                    <li key={task.id}>
                        <strong>{task.title}</strong> — {task.status}
                    </li>
                ))}
            </ul>
        </div>
    );
}

export default App;
