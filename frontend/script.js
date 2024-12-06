document.addEventListener("DOMContentLoaded", () => {
    const wasteForm = document.getElementById("wasteForm");
    const requestTable = document.getElementById("requestTable");

    // Handle form submission
    wasteForm.addEventListener("submit", (e) => {
        e.preventDefault();

        // Gather form data
        const userId = document.getElementById("userId").value;
        const wasteType = document.getElementById("wasteType").value;
        const location = document.getElementById("location").value;
        const status = document.getElementById("status").value;
        const requestDate = document.getElementById("requestDate").value;

        // Send data to backend (optional, for now, just add to table)
        const requestData = { userId, wasteType, location, status, requestDate };

        // Add new row to table
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${userId}</td>
            <td>${wasteType}</td>
            <td>${location}</td>
            <td>${status}</td>
            <td>${requestDate}</td>
        `;
        requestTable.appendChild(row);

        // Clear form
        wasteForm.reset();
    });
});
